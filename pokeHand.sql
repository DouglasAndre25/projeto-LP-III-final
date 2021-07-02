-- Base De Dados 
CREATE DATABASE PokeHand
GO

USE PokeHand
GO

CREATE RULE negative_range AS @range >= 0
GO

-- Tabela Treiandor
CREATE TABLE trainer (
    id INT IDENTITY(1,1),
    name NVARCHAR(50) NOT NULL,
    age INT NOT NULL,
    vocation NVARCHAR(50) NOT NULL,
    nick_name AS name + '@' + vocation PERSISTED,
    CONSTRAINT pk_trainer PRIMARY KEY (id)
);
GO

-- Tabela Pokemon
CREATE TABLE pokemon (
    id INT IDENTITY(1,1),
    name NVARCHAR(50) NOT NULL,
    weight REAL NOT NULL,
    height REAL NOT NULL,
    description NVARCHAR(MAX),
    CONSTRAINT pk_pokemon PRIMARY KEY (id)
);
GO

-- Tabela tipo
CREATE TABLE type (
    id INT IDENTITY(1,1),
    name NVARCHAR(50) NOT NULL,
    CONSTRAINT pk_type PRIMARY KEY (ID)
);
GO

-- Tabela Ataque
CREATE TABLE attack (
    id INT IDENTITY(1,1),
    name NVARCHAR(50) NOT NULL,
    damage REAL NOT NULL DEFAULT 20,
    power_point INT NOT NULL DEFAULT 10,
    accuracy REAL NOT NULL DEFAULT 100,
    type_id INT,
    CONSTRAINT pk_attack PRIMARY KEY (id),
    CONSTRAINT fk_attack_id8 FOREIGN KEY (type_id) REFERENCES type (id) ON DELETE SET NULL
);
GO

-- Tabela treinador_pokemon
CREATE TABLE trainer_pokemon (
    id INT IDENTITY(1,1),
    life INT NOT NULL DEFAULT 0,
    level INT NOT NULL DEFAULT 1,
    trainer_id INT NOT NULL,
    pokemon_id INT NOT NULL,
    CONSTRAINT pk_trainer_pokemon PRIMARY KEY (id),
    CONSTRAINT fk_trainer_id FOREIGN KEY (trainer_id) REFERENCES trainer (id) ON DELETE CASCADE,
    CONSTRAINT fk_pokemon_id1 FOREIGN KEY (pokemon_id) REFERENCES pokemon (id) ON DELETE CASCADE
);
GO

-- Tabela ataque_pokemon
CREATE TABLE attack_pokemon (
    id INT IDENTITY(1,1),
    pokemon_id INT NOT NULL,
    attack_id INT NOT NULL,
    CONSTRAINT pk_attack_pokemon PRIMARY KEY (id),
    CONSTRAINT fk_pokemon_id4 FOREIGN KEY (pokemon_id) REFERENCES pokemon (id) ON DELETE CASCADE,
    CONSTRAINT fk_attack_id1 FOREIGN KEY (attack_id) REFERENCES attack (id) ON DELETE CASCADE,
);
GO

EXECUTE sp_bindrule negative_range, 'trainer.age'
EXECUTE sp_bindrule negative_range, 'pokemon.weight'
EXECUTE sp_bindrule negative_range, 'pokemon.height'
EXECUTE sp_bindrule negative_range, 'attack.damage'
EXECUTE sp_bindrule negative_range, 'attack.power_point'
EXECUTE sp_bindrule negative_range, 'attack.accuracy'
EXECUTE sp_bindrule negative_range, 'trainer_pokemon.life'
EXECUTE sp_bindrule negative_range, 'trainer_pokemon.level'
GO
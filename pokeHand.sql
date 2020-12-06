-- Base De Dados 
CREATE DATABASE PokeHand
GO

USE PokeHand
GO

-- Tabela Treiandor
CREATE TABLE trainer (
    id INT IDENTITY(1,1),
    name NVARCHAR(50) NOT NULL,
    age INT NOT NULL,
    vocation NVARCHAR(50) NOT NULL,
    CONSTRAINT pk_trainer PRIMARY KEY (id)
);
GO

-- Tabela Pokemon
CREATE TABLE pokemon (
    id INT IDENTITY(1,1),
    name NVARCHAR(50) NOT NULL,
    weight REAL NOT NULL,
    height REAL NOT NULL,
    sprite Image,
    description NVARCHAR(MAX),
    CONSTRAINT pk_pokemon PRIMARY KEY (id)
);
GO

-- Tabela Ataque
CREATE TABLE attack (
    id INT IDENTITY(1,1),
    name NVARCHAR(50) NOT NULL,
    damage REAL NOT NULL,
    power_point INT NOT NULL,
    accuracy REAL NOT NULL,
    CONSTRAINT pk_attack PRIMARY KEY (id)
);
GO

-- Tabela tipo
CREATE TABLE type (
    id INT IDENTITY(1,1),
    name NVARCHAR(50) NOT NULL,
    CONSTRAINT pk_type PRIMARY KEY (ID)
);
GO

-- Tabela treinador_pokemon
CREATE TABLE trainer_pokemon (
    id INT IDENTITY(1,1),
    life INT NOT NULL,
    level INT NOT NULL,
    trainer_id INT NOT NULL,
    pokemon_id INT NOT NULL,
    CONSTRAINT pk_trainer_pokemon PRIMARY KEY (id),
    CONSTRAINT fk_trainer_id FOREIGN KEY (trainer_id) REFERENCES trainer (id),
    CONSTRAINT fk_pokemon_id1 FOREIGN KEY (pokemon_id) REFERENCES pokemon (id)
);
GO

-- Tabela tipo_pokemon
CREATE TABLE type_pokemon (
    id INT IDENTITY(1,1),
    pokemon_id INT NOT NULL,
    type_id INT NOT NULL,
    CONSTRAINT pk_type_pokemon PRIMARY KEY (id),
    CONSTRAINT fk_pokemon_id2 FOREIGN KEY (pokemon_id) REFERENCES pokemon (id),
    CONSTRAINT fk_type_id FOREIGN KEY (type_id) REFERENCES type (id)
);
GO

-- Tabela ataque_pokemon
CREATE TABLE attack_pokemon (
    id INT IDENTITY(1,1),
    pokemon_id INT NOT NULL,
    attack_id INT NOT NULL,
    CONSTRAINT pk_attack_pokemon PRIMARY KEY (id),
    CONSTRAINT fk_pokemon_id4 FOREIGN KEY (pokemon_id) REFERENCES pokemon (id),
    CONSTRAINT fk_attack_id1 FOREIGN KEY (attack_id) REFERENCES attack (id),
);
GO

-- Tabela tipo_ataque
CREATE TABLE type_attack (
    id INT IDENTITY(1,1),
    attack_id INT NOT NULL,
    type_id INT NOT NULL,
    CONSTRAINT pk_type_attack PRIMARY KEY (id),
    CONSTRAINT fk_attack_id3 FOREIGN KEY (attack_id) REFERENCES attack (id),
    CONSTRAINT fk_type_id3 FOREIGN KEY (type_id) REFERENCES type (id)
);
GO
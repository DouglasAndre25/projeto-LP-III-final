CREATE OR ALTER VIEW get_info_pokemon
AS
    SELECT pokemon.id, trainer_pokemon.level, trainer_pokemon.life
    FROM trainer_pokemon
    INNER JOIN pokemon ON pokemon.id = trainer_pokemon.pokemon_id
    WHERE trainer_pokemon.trainer_id = 1;

CREATE VIEW get_trainer_data
AS
    SELECT * FROM trainer WHERE id = 1;

CREATE VIEW get_last_change
AS
    SELECT TOP(1) create_date FROM poke_log
    ORDER BY create_date DESC

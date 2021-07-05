CREATE OR ALTER FUNCTION get_pokemon_id_by_name (@name NVARCHAR(50))
RETURNS TABLE
AS
RETURN (
    SELECT id FROM pokemon
    WHERE [name] LIKE @name
)
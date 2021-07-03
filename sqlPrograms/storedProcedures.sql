CREATE PROCEDURE type_by_name (@name AS NVARCHAR(50))
AS
    SELECT id, name FROM type WHERE name LIKE '%' + @name + '%'
GO

CREATE OR ALTER PROCEDURE attack_filter 
(
    @name AS NVARCHAR(50) = '',
    @minDamage AS REAL,
    @maxDamage AS REAL,
    @minPp AS REAL,
    @maxPp AS REAL,
    @minAccuracy AS REAL,
    @maxAccuracy AS REAL
)
AS
    SELECT attack.id, attack.name as nome, attack.accuracy as precisão, attack.damage as dano, attack.power_point as PP, type.name as tipo, type.id as codigo_tipo
    FROM attack
    INNER JOIN type on type.id = attack.type_id
    WHERE attack.name LIKE '%' + @name + '%'
    AND attack.accuracy > @minAccuracy
    AND attack.accuracy < @maxAccuracy
    AND attack.damage > @minDamage
    AND attack.damage < @maxDamage
    AND attack.power_point > @minPp
    AND attack.power_point < @maxPp
GO


-- 2.147.483.647
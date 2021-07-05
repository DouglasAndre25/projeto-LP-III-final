CREATE OR ALTER TRIGGER update_trainer_log
ON trainer
AFTER UPDATE
AS
    DECLARE @name AS NVARCHAR(50)
    SELECT @name = name FROM inserted;
    INSERT INTO poke_log VALUES (
        'O treinador com o nome ' + @name + ' atualizou as informações',
        GETDATE()
    )
GO

CREATE OR ALTER TRIGGER create_pokemon_log
ON pokemon
AFTER INSERT
AS
    DECLARE @name AS NVARCHAR(50)
    SELECT @name = name FROM inserted
    INSERT INTO poke_log VALUES (
        'O pokemon com o nome ' + @name + ' foi criado',
        GETDATE()
    )
GO

CREATE OR ALTER TRIGGER update_pokemon_log
ON pokemon
AFTER UPDATE
AS
    DECLARE @name AS NVARCHAR(50)
    SELECT @name = name FROM inserted
    INSERT INTO poke_log VALUES (
        'O pokemon com o nome ' + @name + ' foram atualizadas as informações',
        GETDATE()
    )
GO

CREATE OR ALTER TRIGGER delete_pokemon_log
ON pokemon
AFTER DELETE
AS
    DECLARE @name AS NVARCHAR(50)
    SELECT @name = name FROM deleted
    INSERT INTO poke_log VALUES (
        'O pokemon com o nome ' + @name + ' foi excluído',
        GETDATE()
    )
GO


CREATE OR ALTER TRIGGER create_attack_log
ON attack
AFTER INSERT
AS
    DECLARE @name AS NVARCHAR(50)
    SELECT @name = name FROM inserted
    INSERT INTO poke_log VALUES (
        'O ataque com o nome ' + @name + ' foi criado',
        GETDATE()
    )
GO

CREATE OR ALTER TRIGGER update_attack_log
ON attack
AFTER UPDATE
AS
    DECLARE @name AS NVARCHAR(50)
    SELECT @name = name FROM inserted
    INSERT INTO poke_log VALUES (
        'O ataque com o nome ' + @name + ' foi atualizado as informações',
        GETDATE()
    )
GO

CREATE OR ALTER TRIGGER delete_attack_log
ON attack
AFTER DELETE
AS
    DECLARE @name AS NVARCHAR(50)
    SELECT @name = name FROM deleted
    INSERT INTO poke_log VALUES (
        'O ataque com o nome ' + @name + ' foi excluído',
        GETDATE()
    )
GO

CREATE OR ALTER TRIGGER create_type_log
ON [type]
AFTER INSERT
AS
    DECLARE @name AS NVARCHAR(50)
    SELECT @name = name FROM inserted
    INSERT INTO poke_log VALUES (
        'O tipo com o nome ' + @name + ' foi criado',
        GETDATE()
    )
GO

CREATE OR ALTER TRIGGER update_type_log
ON [type]
AFTER UPDATE
AS
    DECLARE @name AS NVARCHAR(50)
    SELECT @name = name FROM inserted
    INSERT INTO poke_log VALUES (
        'O tipo com o nome ' + @name + ' foi atualizado as informações',
        GETDATE()
    )
GO

CREATE OR ALTER TRIGGER delete_type_log
ON [type]
AFTER DELETE
AS
    DECLARE @name AS NVARCHAR(50)
    SELECT @name = name FROM deleted
    INSERT INTO poke_log VALUES (
        'O tipo com o nome ' + @name + ' foi excluído',
        GETDATE()
    )
GO
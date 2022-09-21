CREATE TABLE [dbo].[product] (
    [id]                INT    NOT NULL,
    [gtin_code]         BIGINT NULL,
    [quantity_in_stock] INT    NOT NULL,
    [name]              TEXT   NOT NULL,
    [description]       TEXT   NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);


CREATE TABLE [dbo].[shopping-cart] (
    [id]               INT      IDENTITY (1, 1) NOT NULL,
    [customer-id]      INT      NOT NULL,
    [billing-address]  TEXT     NOT NULL,
    [shipping-address] TEXT     NOT NULL,
    [date-created]     DATETIME NOT NULL,
    [date-updated]     DATETIME NULL,
    [date-ordered]     DATETIME NULL,
    [date-shipped]     DATETIME NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_shopping-cart_customer] FOREIGN KEY ([customer-id]) REFERENCES [dbo].[customer] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_shopping-cart_customer-id]
    ON [dbo].[shopping-cart]([customer-id] ASC);


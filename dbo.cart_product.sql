CREATE TABLE [dbo].[cart-product] (
    [shopping-cart-id] INT NOT NULL IDENTITY,
    [product-id]       INT NOT NULL,
    [product-quantity] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([shopping-cart-id] ASC, [product-id] ASC), 
    CONSTRAINT [FK_cart-product_shopping-cart] FOREIGN KEY ([shopping-cart-id]) REFERENCES [shopping-cart]([id]) ON DELETE CASCADE
);


GO

CREATE NONCLUSTERED INDEX [IX_cart-product_shopping-cart-id] ON [dbo].[cart-product] ([shopping-cart-id])

GO

CREATE NONCLUSTERED INDEX [IX_cart-product_product-id] ON [dbo].[cart-product] ([product-id])

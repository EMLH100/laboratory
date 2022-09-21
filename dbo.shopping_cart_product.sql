CREATE TABLE [dbo].[shopping-cart_product] (
    [shopping-cart-id] INT IDENTITY (1, 1) NOT NULL,
    [product-id]       INT NOT NULL,
    [product-quantity] INT NOT NULL, 
    CONSTRAINT [PK_shopping-cart_product] PRIMARY KEY ([shopping-cart-id], [product-id])
);


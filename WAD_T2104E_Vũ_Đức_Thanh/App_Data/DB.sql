Create table Category (
	CategoryId Int NOT NULL PRIMARY KEY,
	CategoryName varchar(255)
);

Create table Product (
	ProductId Int NOT NULL PRIMARY KEY,
	Name varchar(255),
	Price varchar(255),
	Quantity Int,
	ReleaseDate Date,
	CategoryId Int FOREIGN KEY REFERENCES Category(CategoryId)
)

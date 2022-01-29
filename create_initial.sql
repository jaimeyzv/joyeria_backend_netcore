use master
go

create database JoyeriaDB;
go

use JoyeriaDB;
go

create table Categories
(
	Id		int identity primary key not null,
	Name	varchar(100)  not null
)
go

insert into Categories(Name) values ('Baby Lover');
insert into Categories(Name) values ('Peru Lover');
insert into Categories(Name) values ('Aniaml Lover');

select * from Categories;

create table Products
(
	Id			UNIQUEIDENTIFIER primary key not null,
	Name		varchar(100) not null,
	Description varchar(500) not null,
	Stock		int not null,
	Price		decimal(18, 2) not null, -- SOLES
	Category_id int

	foreign key (Category_id) references Categories(Id)
)
go

-- Initial data for 'Para ellos' category => Category Id = 1
--insert into Products(Name, Description, Stock, Price, Category_id) 
--values ('Llavero San Judas', 'Presentativo para religiosos', 10, 159.99, 1);
--insert into Products(Name, Description, Stock, Price, Category_id) 
--values ('Llavero Se�or de los Milagros', 'Presentativo para religiosos', 20, 189.99, 1);
--insert into Products(Name, Description, Stock, Price, Category_id) 
--values ('Llavero Escudo Nacional', 'Presentativo para patriotas', 50, 119.99, 1);
--insert into Products(Name, Description, Stock, Price, Category_id) 
--values ('Collar Firmeza Hombre', 'Presentativo para varones firmes', 5, 465.99, 1);
--insert into Products(Name, Description, Stock, Price, Category_id) 
--values ('Pulsera Confianza Hombre', 'Presentativo para varones confiados', 20, 380.00, 1);
--insert into Products(Name, Description, Stock, Price, Category_id) 
--values ('Anillo Equilibrio Hombre', 'Presentativo para varones equilibrados', 30, 340.00, 1);
--insert into Products(Name, Description, Stock, Price, Category_id) 
--values ('Anillo Fe Hombre', 'Presentativo para varones con fe', 15, 360.00, 1);
--insert into Products(Name, Description, Stock, Price, Category_id) 
--values ('Collar Equilibrio Hombre', 'Presentativo para varones equilibrados', 10, 695.00, 1);
--insert into Products(Name, Description, Stock, Price, Category_id) 
--values ('Pulsera Libertad Hombre', 'Presentativo para varones libres', 20, 210.00, 1);
--insert into Products(Name, Description, Stock, Price, Category_id) 
--values ('Collar Infinito Hombre', 'Presentativo para varones infinitos', 5, 885.00, 1);

select * from Products;

create table UserTypes
(
	Id			int identity primary key not null,
	Name		varchar(100) not null,
)
go

insert into UserTypes(Name) values ('Administrador');
insert into UserTypes(Name) values ('Cliente');

select * from UserTypes;

create table DocumentTypes
(
	Id			int identity primary key not null,
	Name		varchar(100) not null,
)
go

insert into DocumentTypes(Name) values ('DNI');
insert into DocumentTypes(Name) values ('RUC');
insert into DocumentTypes(Name) values ('Carnet de Extranjeria');
insert into DocumentTypes(Name) values ('Pasaporte');

select * from DocumentTypes;

create table Users
(
	Id				int identity primary key not null,
	Name			varchar(100) not null,
	LastName		varchar(100) not null,
	DocumentNumber	varchar(11) not null,
	Email			varchar(256) not null,
	Password		varchar(20) not null,
	Address			varchar(150),
	Cellphone		varchar(15),
	UserTypeId		int not null,
	DocumentTypeId	int not null,

	foreign key (UserTypeId) references UserTypes(Id),
	foreign key (DocumentTypeId) references DocumentTypes(Id)
)
go

select * from Users;

create table OrderStatus
(
	Id		int identity primary key not null,
	Name	varchar(150),	
);

insert into OrderStatus(Name) values ('Ordernado');
insert into OrderStatus(Name) values ('En Despacho');
insert into OrderStatus(Name) values ('Enviado');
insert into OrderStatus(Name) values ('Entregado');
insert into OrderStatus(Name) values ('Anulado');

create table Orders
(
	Id			UNIQUEIDENTIFIER primary key not null,
	Date		datetime not null,
	UserId		int not null,
	StatusId	int not null,
	Total		decimal(18, 2) not null,

	foreign key (UserId) references Users(Id),
	foreign key (StatusId) references OrderStatus(Id),
);

select * from Orders;

create table OrderItems
(
	Id			UNIQUEIDENTIFIER primary key not null,
	Amount		int,
	Price		decimal(18, 2) not null,
	TotalAmount	decimal(18, 2) not null, -- Amount * Price
	ProductId	UNIQUEIDENTIFIER not null,
	OrderId		UNIQUEIDENTIFIER not null,	

	foreign key (ProductId) references Products(Id),
	foreign key (OrderId) references Orders(Id),
);

select * from OrderItems;

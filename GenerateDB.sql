create database hotelDB;
go

use hotelDB;
go

create table Customer 
(
	id int identity(1,1) primary key, 
	name nvarchar(50), 
	gender Bit, 
	phone nvarchar(11), 
	address nvarchar(50), 
	personalId nvarchar(12),
);
go

create table Staff 
(
	id int identity(1,1) primary key, 
	name int, 
	gender Bit, 
	phone nvarchar(11), 
	email nvarchar(50),
	username nvarchar(50),
	passwords nvarchar(50), 
);
go

create table Orders
(
	id int identity(1,1) primary key, 
	checkinDate Date,
	checkoutDate Date,
	customerID int foreign key references Customer(id),
	staffID int foreign key references Staff(id),
);
go

create table Floor
(
	id int identity(1,1) primary key,
	name nvarchar(50),

)
go

create table TypeRoom
(
	id int identity(1,1) primary key,
	name nvarchar(50),	 
	price Float,
	maxCus int,
	surCharge Float,
	qtyBed int,
)

create table Room 
(
	id int identity(1,1) primary key, 
	num int,
	status Bit default 0, 
	orderID int foreign key references Orders(id), 
	floorId int foreign key references Floor(id),
	typeRoomId int foreign key references TypeRoom(id)
);
go

create table Product 
(
	id int identity(1,1) primary key, 
	name nvarchar(50), 
	price Float,
);
go

create table Order_Product
(
	orderID int foreign key references Orders(id),
	productID int foreign key references Product(id), 
	constraint PK_OP primary key (orderID, productID)
);




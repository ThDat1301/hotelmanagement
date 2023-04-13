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
	name nvarchar(50), 
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
	totalAmount Float,
	numOfCus int,
	status bit,
	isGroup bit,
	note nvarchar(2000),
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
	num nvarchar(50),
	status Bit default 0, 
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

create table OrderDetailProduct
(
	id int identity(1,1) primary key, 
	quantity int,
	roomID int foreign key references Room(id),
	orderID int foreign key references Orders(id),
	productID int foreign key references Product(id), 
	--constraint PK_OP primary key (orderID, productID)
);
go

create table OrderDetailRoom
(
	id int identity(1,1) primary key, 
	orderID int foreign key references Orders(id),
	roomID int foreign key references Room(id),
	dayAt int,
)

go
USE [hotelDB]
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([id], [name], [gender], [phone], [address], [personalId]) VALUES (1, N'Trần Quốc Hỷ', 1, N'0123456789', N'HCM', N'111111111111')
INSERT [dbo].[Customer] ([id], [name], [gender], [phone], [address], [personalId]) VALUES (2, N'Trương Trọng Nghĩa', 1, N'0123456789', N'HCM', N'111111111111')
INSERT [dbo].[Customer] ([id], [name], [gender], [phone], [address], [personalId]) VALUES (3, N'Mai Thị Tuyết Trinh', 0, N'0123456789', N'PT', N'111111111111')
INSERT [dbo].[Customer] ([id], [name], [gender], [phone], [address], [personalId]) VALUES (4, N'Lê MInh Đức', 1, N'0123456789', N'AG', N'111111111111')
INSERT [dbo].[Customer] ([id], [name], [gender], [phone], [address], [personalId]) VALUES (5, N'Trần Nhật Tiến', 1, N'0123456789', N'H', N'111111111111')
INSERT [dbo].[Customer] ([id], [name], [gender], [phone], [address], [personalId]) VALUES (6, N'Phan Lê Hồ', 1, N'0123456789', N'HCM', N'111111111111')
SET IDENTITY_INSERT [dbo].[Customer] OFF
GO
SET IDENTITY_INSERT [dbo].[Floor] ON 

INSERT [dbo].[Floor] ([id], [name]) VALUES (1, N'Tầng 1')
INSERT [dbo].[Floor] ([id], [name]) VALUES (2, N'Tầng 2')
INSERT [dbo].[Floor] ([id], [name]) VALUES (3, N'Tầng 3')
SET IDENTITY_INSERT [dbo].[Floor] OFF
GO
SET IDENTITY_INSERT [dbo].[TypeRoom] ON 

INSERT [dbo].[TypeRoom] ([id], [name], [price], [maxCus], [surCharge], [qtyBed]) VALUES (1, N'STD', 300000, 2, 30000, 1)
INSERT [dbo].[TypeRoom] ([id], [name], [price], [maxCus], [surCharge], [qtyBed]) VALUES (2, N'SUP', 400000, 5, 30000, 2)
INSERT [dbo].[TypeRoom] ([id], [name], [price], [maxCus], [surCharge], [qtyBed]) VALUES (3, N'DLX', 500000, 8, 30000, 3)
INSERT [dbo].[TypeRoom] ([id], [name], [price], [maxCus], [surCharge], [qtyBed]) VALUES (4, N'SUT', 600000, 8, 50000, 3)
SET IDENTITY_INSERT [dbo].[TypeRoom] OFF
GO
SET IDENTITY_INSERT [dbo].[Room] ON 

INSERT [dbo].[Room] ([id], [num], [status], [floorId], [typeRoomId]) VALUES (1, 101, 0, 1, 1)
INSERT [dbo].[Room] ([id], [num], [status], [floorId], [typeRoomId]) VALUES (2, 102, 0, 1, 2)
INSERT [dbo].[Room] ([id], [num], [status], [floorId], [typeRoomId]) VALUES (3, 103, 0, 1, 3)
INSERT [dbo].[Room] ([id], [num], [status], [floorId], [typeRoomId]) VALUES (4, 201, 0, 2, 4)
INSERT [dbo].[Room] ([id], [num], [status], [floorId], [typeRoomId]) VALUES (5, 202, 0, 2, 4)
INSERT [dbo].[Room] ([id], [num], [status], [floorId], [typeRoomId]) VALUES (6, 203, 0, 2, 2)
INSERT [dbo].[Room] ([id], [num], [status], [floorId], [typeRoomId]) VALUES (7, 301, 0, 3, 1)
INSERT [dbo].[Room] ([id], [num], [status], [floorId], [typeRoomId]) VALUES (8, 302, 0, 3, 3)
INSERT [dbo].[Room] ([id], [num], [status], [floorId], [typeRoomId]) VALUES (9, 303, 0, 3, 1)
SET IDENTITY_INSERT [dbo].[Room] OFF
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([id], [name], [price]) VALUES (1, N'Nước suối', 15000)
INSERT [dbo].[Product] ([id], [name], [price]) VALUES (2, N'Fanta', 20000)
INSERT [dbo].[Product] ([id], [name], [price]) VALUES (3, N'Pepsi', 20000)
INSERT [dbo].[Product] ([id], [name], [price]) VALUES (4, N'Phục vụ bữa sáng', 20000)
INSERT [dbo].[Product] ([id], [name], [price]) VALUES (5, N'Giặt ủi', 20000)
INSERT [dbo].[Product] ([id], [name], [price]) VALUES (6, N'Spa', 20000)
INSERT [dbo].[Product] ([id], [name], [price]) VALUES (7, N'Golf', 20000)

SET IDENTITY_INSERT [dbo].[Product] OFF
GO





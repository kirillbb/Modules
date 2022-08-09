use SalesOrders;

/*1*/
go create procedure sp_CreateTable as
begin 
	create table tb_Results
	(
	SalesOrderID int not null,
	CustomerID int,
	WarehouseCode nchar(20),
	SalesDate DATETIME2(0),
	TotalAmt decimal(25, 6),
	PaidAmt decimal(25, 6)
	)
end;

/*2*/
go create procedure sp_AlterTableAddKeys as
begin
	alter table tb_Results
		add constraint PK_Result  primary key(SalesOrderID),
			constraint FK_Result_Customer foreign key(CustomerID) references Customer(CustomerID);
end;

/*3*/
go create procedure sp_SelectInsert as
begin
	insert tb_Results
	select sa.SalesOrderID, cu.CustomerID, wa.WarehouseCode, sa.SalesDate, sa.TotalAmt, sa.PaidAmt from dbo.SalesOrder sa
	join  dbo.Warehouse wa on sa.WarehouseID = wa.WarehouseID
	join dbo.Customer cu on sa.CustomerID = cu.CustomerID
	where cu.State in ('IL', 'NY', 'MO')
end;

/*4*/
go create procedure sp_UpdateDelete as
begin
	delete tb_Results
	where TotalAmt = PaidAmt;
	update tb_Results
	set PaidAmt = 100
	where (TotalAmt - PaidAmt) >= 100
end;

/*5*/
go create procedure sp_GetInfoByCustomer as /* не доделал*/
begin
	select 
	max(CustomerID) as CustomerID, 
	count(CustomerID) as Count
	
	from
	dbo.SalesOrder
	group by (CustomerID)
end;

/*6*/
go create procedure sp_GetInfoByUnpaidCustomer as /* не сделал*/
begin
	
end;

/*7*/
go create procedure sp_GetAverageSalesOrderAmt	/* не сделал, не получилось*/
					@averageSalesOrderAmt decimal(25, 6) output 
as
begin

end;

/*8*/
go create procedure sp_DropTable as
begin
	drop table tb_Results;
end;
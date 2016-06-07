use store
select Item.ItemName, OrdersItem.Quantity
from Item
inner join OrdersItem on Item.ItemID = OrdersItem.ItemID
inner join Orders on OrdersItem.OrderID = Orders.OrderID
where Orders.EstimatedDeliveryDate < SYSDATETIME() and
datediff(day, Orders.EstimatedDeliveryDate, SYSDATETIME()) <= 21 
and  OrdersItem.DeliveredDate is null

Set Language 'Russian'
select top 1 Item.ItemName ItemName, SUM(OutBillItem.Quantity) as Quantity
from Item
inner join OutBillItem on Item.ItemID = OutBillItem.ItemID
where year(OutBillItem.GivenDate) >= YEAR(sysdatetime()) and 
datepart(WEEKDAY, OutBillItem.GivenDate) = 5
group by Item.ItemName
order by Quantity desc

select sum(OrdersItem.Price * OrdersItem.Quantity)/sum(OrdersItem.Quantity) as AvgPr,
min(OrdersItem.Price) as MinPr, 
100.0 * (1 - min(OrdersItem.Price)/(sum(OrdersItem.Price * OrdersItem.Quantity)/sum(OrdersItem.Quantity))) as DiffFromMin,
max(OrdersItem.Price) as MaxPr,
100.0 * (1 - (sum(OrdersItem.Price * OrdersItem.Quantity)/sum(OrdersItem.Quantity))/max(OrdersItem.Price)) as DiffFromMax
from Item
inner join OrdersItem on Item.ItemID = OrdersItem.ItemID
group by Item.ItemName
having (100.0 * (1 - min(OrdersItem.Price)/(sum(OrdersItem.Price * OrdersItem.Quantity)/sum(OrdersItem.Quantity))) > 15.00) or
(100.0 * (1 - (sum(OrdersItem.Price * OrdersItem.Quantity)/sum(OrdersItem.Quantity))/max(OrdersItem.Price)) > 15.00)




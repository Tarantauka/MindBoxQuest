select prod.name, cat.name from product as prod
left join dbo.product_category on product_id = id
left join dbo.category as cat on catefory_id = cat.id
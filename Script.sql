Query de consulta:

select * from CONTA co
inner join CATEGORIA ca
	on co.CATEGORIA_ID = ca.ID
where 
	co.USUARIO_ID = '11555c8c-6fe0-401f-bbfc-65e504de2b7a'
and 
	co.DATA between '2023-05-01' AND '2023-05-31'
order by 
	co.DATA
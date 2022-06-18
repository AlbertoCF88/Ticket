create database FACTURA;
use factura;

CREATE TABLE `ticket` (
  `id` int auto_increment ,
  `fecha` datetime NOT NULL,
  `concepto` varchar(600) NOT NULL ,
  `importe` double NOT null,
  PRIMARY KEY (`id`)
);

insert into ticket value (0, NOW(),'Ticket de prueba',5 );


select *
from ticket;





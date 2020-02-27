-- This SQL script using for Postgresql Database

CREATE DATABASE donetcorepractice

--DROP DATABASE donetcorepractice

CREATE TABLE public.product(
	id serial ,
	name varchar(200),
	code varchar(200),
	price bigint,
	stock bigint
)

INSERT INTO public.product ("name",code,price,stock) VALUES ('K?o cao su','89312345789',2500,400);
INSERT INTO public.product ("name",code,price,stock) VALUES ('Snack Bò Rau Th?m','89311987469',5000,20);
INSERT INTO public.product ("name",code,price,stock) VALUES ('S?a H?p','89311987469',17000,20);
INSERT INTO public.product ("name",code,price,stock) VALUES ('Mì Tôm Chua Cay','89311987469',15000,20);
INSERT INTO public.product ("name",code,price,stock) VALUES ('R??u Vang','89311987469',57000,20);
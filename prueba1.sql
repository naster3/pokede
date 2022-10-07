
create database dbpokemon;
go
use dbpokemon;
go
CREATE TABLE pokemon(

idPokemon int NOT NULL,
nombre varchar(80) ,
fecha datetime ,
tipo int,
constraint pk_pokemon primary key(idPokemon)
);

create table tipo(
idtipo int not null,
nombre varchar(25),
constraint pk_tipo primary key(idtipo)
);

alter table Pokemon add constraint FK_Pokemon_IdTipo foreign key (tipo) references tipo (Idtipo);
--ALTER TABLE Pokemon
--ADD FOREIGN KEY (Tipo) REFERENCES Tipo (IdTipo);
create table orden(
ordenID int not null,
ordenNumero int,
idtipo int foreign key references tipo(idtipo),
idPokemon int foreign key references pokemon(idPokemon),
primary key (ordenID),
);
go
--drop table pokemon;
--alter table orden
--adrop constraint pokemon;
select idtipo,nombre from tipo
insert into tipo(idtipo,nombre)values('19','???');
go
select * from tipo
create procedure sp_tipocombobox 
as select idtipo,nombre from tipo exec sp_tipocombobox go
--crud de data grid.

--select idPokemon,nombre,fecha,tipo from pokemon;
--go
--insert into pokemon (idPokemon,nombre,fecha,tipo) values('','charmander','9/9/2022','1')
--go


select top (1000)[idPokemon],
[nombre],
[fecha],[tipo]
from[dbpokemon].[dbo].[pokemon]
go 

create database Usuario;
go

use Usuario;
go
create table pessoa (
	id			int			not null primary key identity,
	nome		varchar(50)	not null,
	sobreNome	varchar(50) not null,
	cpf			varchar(11) not null,
	salario		money
)
go


create table endereco (
	idEndereco		int			not null primary key   references pessoa,
	cep				varchar(8)	not null,
	bairro			varchar(50) not null,
	logradouro		varchar(50) not null,
)
go

create procedure cadPessoa
(
   @nome varchar(50), @sobrenome varchar(50), @cpf varchar(11), @salario money, @cep varchar(8), @bairro varchar(50), @logradouro varchar(50)
)
as
begin
    insert into pessoa values (@nome, @sobrenome, @cpf, @salario)
	insert into endereco  values (@@IDENTITY, @cep, @bairro, @logradouro )

end
go

exec cadPessoa 'Felipe', 'Pestana', '00000000', 100.00, '15250801', 'Anchieta', 'Rua Companhia de Jesus'
go

create view v_pessoa
as
	select * from pessoa p join  endereco e on  p.id = e.idEndereco
go



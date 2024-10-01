create database db_gerenciador_financeiro;

use db_gerenciador_financeiro;
go

use [master]
go

drop database db_gerenciador_financeiro
go

create table tb_usuarios(
cod_usuario int identity not null,
nome varchar(50) not null,
sobrenome varchar(50) not null,
cpf varchar (14) not null,
data_nasc Date not null,
sexo char (1) default 'M' not null,
constraint un_cpf unique(cpf),
constraint PK_codUsuario primary key(cod_usuario)
)
go

create table tb_login(
cod_login int identity not null,
cod_usuario int not null,
nome_login varchar(50) not null,
senha_login varchar(12) not null,
constraint PK_CodLogin primary key(cod_login),
constraint CK_EmailFormato CHECK (nome_login LIKE '%@%.%')
)
go

create table tb_contas(
cod_conta int identity not null,
cod_usuario int,
tipo varchar(8) not null,
data_cont smalldatetime not null,
valor decimal(10, 2) check (valor > 0) not null,
descricao varchar(150) not null,
constraint PK_codConta primary key(cod_conta)
)
go

create table tb_bancos(
cod_banco int identity not null,
cod_usuario int,
nome_banco varchar(20) not null,
saldo decimal(10, 2) check (saldo > 0) not null,
constraint PK_codBanco primary key(cod_banco)
)
go

/*Referencias tb_usuario e tb_login*/
create table login_usuario(
cod_usuario int foreign key
references tb_usuarios,
cod_login int foreign key 
references tb_login
)
go

/* referencia a tabela de contas com a tabela de usuarios*/
create table conta_usuario(
cod_usuario int foreign key
references tb_usuarios,
cod_conta int foreign key
references tb_contas
)
go

/* referencia a tabela de banco com a tabela de usuarios*/
create table banco_usuario(
cod_usuario int foreign key
references tb_usuarios,
cod_banco int foreign key
references tb_bancos
)
go


 

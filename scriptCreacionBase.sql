/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     07/02/2017 16:40:51                          */
/*==============================================================*/

create database ProyPropietarios;

use ProyPropietarios;

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DETALLEFACTURA') and o.name = 'FK_DETALLEF_DETALLEFA_ORDENDET')
alter table DETALLEFACTURA
   drop constraint FK_DETALLEF_DETALLEFA_ORDENDET
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DETALLEFACTURA') and o.name = 'FK_DETALLEF_F_FACTURA')
alter table DETALLEFACTURA
   drop constraint FK_DETALLEF_F_FACTURA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DETALLEFACTURA') and o.name = 'FK_DETALLEF_RELA_PRODUCTO')
alter table DETALLEFACTURA
   drop constraint FK_DETALLEF_RELA_PRODUCTO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('FACTURA') and o.name = 'FK_FACTURA_CLIENTE_F_CLIENTE')
alter table FACTURA
   drop constraint FK_FACTURA_CLIENTE_F_CLIENTE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ORDENDETRABAJO') and o.name = 'FK_ORDENDET_CLIENTE_O_CLIENTE')
alter table ORDENDETRABAJO
   drop constraint FK_ORDENDET_CLIENTE_O_CLIENTE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CLIENTE')
            and   type = 'U')
   drop table CLIENTE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DETALLEFACTURA')
            and   name  = 'RELA_FK'
            and   indid > 0
            and   indid < 255)
   drop index DETALLEFACTURA.RELA_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DETALLEFACTURA')
            and   name  = 'DETALLEFACTURA_ORDENTRABAJO_FK'
            and   indid > 0
            and   indid < 255)
   drop index DETALLEFACTURA.DETALLEFACTURA_ORDENTRABAJO_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DETALLEFACTURA')
            and   name  = 'F_FK'
            and   indid > 0
            and   indid < 255)
   drop index DETALLEFACTURA.F_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DETALLEFACTURA')
            and   type = 'U')
   drop table DETALLEFACTURA
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('FACTURA')
            and   name  = 'CLIENTE_FACTURA_FK'
            and   indid > 0
            and   indid < 255)
   drop index FACTURA.CLIENTE_FACTURA_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('FACTURA')
            and   type = 'U')
   drop table FACTURA
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ORDENDETRABAJO')
            and   name  = 'CLIENTE_ORDENTRABAJO_FK'
            and   indid > 0
            and   indid < 255)
   drop index ORDENDETRABAJO.CLIENTE_ORDENTRABAJO_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ORDENDETRABAJO')
            and   type = 'U')
   drop table ORDENDETRABAJO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PARAMETROS')
            and   type = 'U')
   drop table PARAMETROS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PRODUCTO')
            and   type = 'U')
   drop table PRODUCTO
go

/*==============================================================*/
/* Table: CLIENTE                                               */
/*==============================================================*/
create table CLIENTE (
   CI_CLIENTE           varchar(10)          not null,
   NOMBRECLIENTE        varchar(60)          null,
   TELEFONOCLIENTE      varchar(10)          null,
   DIRECCIONCLIENTE     varchar(150)         null,
   RUCCLIENTE           varchar(13)          null,
   CORREOCLIENTE        varchar(40)          null,
   ESTADOCLIENTE        char(1)              null,
   constraint PK_CLIENTE primary key nonclustered (CI_CLIENTE)
)
go

/*==============================================================*/
/* Table: DETALLEFACTURA                                        */
/*==============================================================*/
create table DETALLEFACTURA (
   ID_DETALLEFACTURA    int                  not null,
   NUM_FACTURA          int                  not null,
   NUM_ORDENTRABAJO     varchar(20)          null,
   ID_PRODUCTO          int                  null,
   CANTIDAD             int                  null,
   PRECIO_UNITARIO      decimal              null,
   constraint PK_DETALLEFACTURA primary key nonclustered (ID_DETALLEFACTURA)
)
go

/*==============================================================*/
/* Index: F_FK                                                  */
/*==============================================================*/
create index F_FK on DETALLEFACTURA (
NUM_FACTURA ASC
)
go

/*==============================================================*/
/* Index: DETALLEFACTURA_ORDENTRABAJO_FK                        */
/*==============================================================*/
create index DETALLEFACTURA_ORDENTRABAJO_FK on DETALLEFACTURA (
NUM_ORDENTRABAJO ASC
)
go

/*==============================================================*/
/* Index: RELA_FK                                               */
/*==============================================================*/
create index RELA_FK on DETALLEFACTURA (
ID_PRODUCTO ASC
)
go

/*==============================================================*/
/* Table: FACTURA                                               */
/*==============================================================*/
create table FACTURA (
   NUM_FACTURA          int                  not null,
   FECHAEMISIONF        datetime             null,
   CI_CLIENTE           varchar(10)          not null,
   DESCUENTO_F          decimal              null,
   ESTADOFACTURA        char(1)              null,
   constraint PK_FACTURA primary key nonclustered (NUM_FACTURA)
)
go

/*==============================================================*/
/* Index: CLIENTE_FACTURA_FK                                    */
/*==============================================================*/
create index CLIENTE_FACTURA_FK on FACTURA (
CI_CLIENTE ASC
)
go

/*==============================================================*/
/* Table: ORDENDETRABAJO                                        */
/*==============================================================*/
create table ORDENDETRABAJO (
   NUM_ORDENTRABAJO     varchar(20)          not null,
   CI_CLIENTE           varchar(10)          not null,
   TIPOORDENTRABAJO     char(1)              null,
   FECHARECEP_REV       datetime             null,
   FECHAENTREGA         datetime             null,
   HORAINICIOC          datetime             null,
   HABILITADA           char(1)              null,
   ESTADOOT             char(1)              null,
   DESCRIPCIONOT        varchar(300)         null,
   COSTOOT              decimal              null,
   constraint PK_ORDENDETRABAJO primary key nonclustered (NUM_ORDENTRABAJO)
)
go

/*==============================================================*/
/* Index: CLIENTE_ORDENTRABAJO_FK                               */
/*==============================================================*/
create index CLIENTE_ORDENTRABAJO_FK on ORDENDETRABAJO (
CI_CLIENTE ASC
)
go

/*==============================================================*/
/* Table: PARAMETROS                                            */
/*==============================================================*/
create table PARAMETROS (
   IVA                  int                  null,
   FECHACADUCIDADF      datetime             null,
   SERIE                varchar(1024)        null,
   AUTORIZACION         varchar(1024)        null,
   NUMINICIAL           int                  null,
   NUMFINAL             int                  null
)
go

/*==============================================================*/
/* Table: PRODUCTO                                              */
/*==============================================================*/
create table PRODUCTO (
   ID_ELECTRODVENTA     int                  not null,
   NOMBRE               varchar(20)          null,
   MODELO               varchar(30)          null,
   TIEMPOUSOELEC        int                  null,
   NUMSERIE             varchar(15)          null,
   PRECIOCOMPRA         decimal              null,
   PRECIOVENTA          decimal              null,
   ESTADOPROD           char(1)              null,
   PROPANTERIOR         varchar(60)          null,
   TELEFPROPANTERIOR    varchar(10)          null,
   constraint PK_PRODUCTO primary key nonclustered (ID_ELECTRODVENTA)
)
go

alter table DETALLEFACTURA
   add constraint FK_DETALLEF_DETALLEFA_ORDENDET foreign key (NUM_ORDENTRABAJO)
      references ORDENDETRABAJO (NUM_ORDENTRABAJO)
go

alter table DETALLEFACTURA
   add constraint FK_DETALLEF_F_FACTURA foreign key (NUM_FACTURA)
      references FACTURA (NUM_FACTURA)
go

alter table DETALLEFACTURA
   add constraint FK_DETALLEF_RELA_PRODUCTO foreign key (ID_PRODUCTO)
      references PRODUCTO (ID_ELECTRODVENTA)
go

alter table FACTURA
   add constraint FK_FACTURA_CLIENTE_F_CLIENTE foreign key (CI_CLIENTE)
      references CLIENTE (CI_CLIENTE)
go

alter table ORDENDETRABAJO
   add constraint FK_ORDENDET_CLIENTE_O_CLIENTE foreign key (CI_CLIENTE)
      references CLIENTE (CI_CLIENTE)
go


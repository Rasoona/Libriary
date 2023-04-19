/*==============================================================*/
/* DBMS name:      MySQL 5.0                                    */
/* Created on:     19.04.2023 12:31:56                          */
/*==============================================================*/


/*==============================================================*/
/* Table: Books                                                 */
/*==============================================================*/
create table Books
(
   bk_id                tinyint not null  comment '',
   bk_author            text  comment '',
   bk_publishYear       date  comment '',
   bk_publiser          text  comment '',
   bk_genre             text  comment '',
   bk_coverType         text  comment '',
   bk_availiability     bool  comment '',
   bk_pagesCount        decimal  comment '',
   primary key (bk_id)
);

/*==============================================================*/
/* Table: BooksUser                                             */
/*==============================================================*/
create table BooksUser
(
   us_id                tinyint not null  comment '',
   bk_id                tinyint not null  comment '',
   bu_extradictionDate  date  comment '',
   bu_returnDate        date  comment '',
   bu_note              text  comment '',
   primary key (us_id, bk_id)
);

/*==============================================================*/
/* Table: ForeignBooks                                          */
/*==============================================================*/
create table ForeignBooks
(
   bk_id                tinyint not null  comment '',
   fb_id                tinyint not null  comment '',
   bk_author            text  comment '',
   bk_publishYear       date  comment '',
   bk_publiser          text  comment '',
   bk_genre             text  comment '',
   bk_coverType         text  comment '',
   bk_availiability     bool  comment '',
   bk_pagesCount        decimal  comment '',
   fb_originalLanguege  text  comment '',
   fb_license           text  comment '',
   fb_originalId        tinyint  comment '',
   primary key (bk_id, fb_id)
);

/*==============================================================*/
/* Table: IllustratedBook                                       */
/*==============================================================*/
create table IllustratedBook
(
   bk_id                tinyint not null  comment '',
   ib_id                tinyint not null  comment '',
   bk_author            text  comment '',
   bk_publishYear       date  comment '',
   bk_publiser          text  comment '',
   bk_genre             text  comment '',
   bk_coverType         text  comment '',
   bk_availiability     bool  comment '',
   bk_pagesCount        decimal  comment '',
   ib_illustrator       text  comment '',
   ib_colored           bool  comment '',
   ib_originlId         tinyint  comment '',
   primary key (bk_id, ib_id)
);

/*==============================================================*/
/* Table: User                                                  */
/*==============================================================*/
create table User
(
   us_id                tinyint not null  comment '',
   us_name              text  comment '',
   us_notes             text  comment '',
   primary key (us_id)
);

alter table BooksUser add constraint FK_BOOKSUSE_TAKE_BOOKS foreign key (bk_id)
      references Books (bk_id) on delete restrict on update restrict;

alter table BooksUser add constraint FK_BOOKSUSE_WRITE_USER foreign key (us_id)
      references User (us_id) on delete restrict on update restrict;

alter table ForeignBooks add constraint FK_FOREIGNB_INHERITAN_BOOKS foreign key (bk_id)
      references Books (bk_id) on delete restrict on update restrict;

alter table IllustratedBook add constraint FK_ILLUSTRA_INHERITAN_BOOKS foreign key (bk_id)
      references Books (bk_id) on delete restrict on update restrict;


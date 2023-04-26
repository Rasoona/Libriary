#
# TABLE STRUCTURE FOR: Books
#

CREATE TABLE `Books` (
  `bk_id` tinyint(4) NOT NULL,
  `bk_name` text COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `bk_author` text COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `bk_publishYear` date DEFAULT NULL,
  `bk_publiser` text COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `bk_genre` text COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `bk_coverType` text COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `bk_availiability` tinyint(1) DEFAULT NULL,
  `bk_pagesCount` decimal(10,0) DEFAULT NULL,
  PRIMARY KEY (`bk_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

INSERT INTO `Books` (`bk_id`, `bk_name`, `bk_author`, `bk_publishYear`, `bk_publiser`, `bk_genre`, `bk_coverType`, `bk_availiability`, `bk_pagesCount`) VALUES (0, 'Earum consequatur quos sunt facilis.', 'Анфиса Сергеевич Громов', '2015-07-14', 'Сысоев, Якушев and Гришин', 'accusantium', 'in', 1, '512');
INSERT INTO `Books` (`bk_id`, `bk_name`, `bk_author`, `bk_publishYear`, `bk_publiser`, `bk_genre`, `bk_coverType`, `bk_availiability`, `bk_pagesCount`) VALUES (1, 'Error libero est id sed exercitationem.', 'Афанасий Сергеевич Матвеев', '1983-11-17', 'Авдеев-Харитонов', 'qui', 'voluptatem', 0, '259');
INSERT INTO `Books` (`bk_id`, `bk_name`, `bk_author`, `bk_publishYear`, `bk_publiser`, `bk_genre`, `bk_coverType`, `bk_availiability`, `bk_pagesCount`) VALUES (2, 'Dolores molestias eos ut eius nam natus amet aperiam.', 'Сазонов Евгения Алексеевич', '2005-04-16', 'Романов, Комиссаров and Быков', 'est', 'necessitatibus', 0, '30');
INSERT INTO `Books` (`bk_id`, `bk_name`, `bk_author`, `bk_publishYear`, `bk_publiser`, `bk_genre`, `bk_coverType`, `bk_availiability`, `bk_pagesCount`) VALUES (3, 'Eum architecto maiores asperiores omnis commodi delectus.', 'Капитолина Сергеевич Исаев', '1984-08-20', 'Юдин-Алексеев', 'aliquam', 'nobis', 1, '768');
INSERT INTO `Books` (`bk_id`, `bk_name`, `bk_author`, `bk_publishYear`, `bk_publiser`, `bk_genre`, `bk_coverType`, `bk_availiability`, `bk_pagesCount`) VALUES (4, 'Aliquam voluptatem sit molestias voluptates culpa autem.', 'Тарасов Рада Борисович', '1988-07-12', 'Носов LLC', 'doloribus', 'ut', 0, '380');
INSERT INTO `Books` (`bk_id`, `bk_name`, `bk_author`, `bk_publishYear`, `bk_publiser`, `bk_genre`, `bk_coverType`, `bk_availiability`, `bk_pagesCount`) VALUES (5, 'Esse ut nesciunt voluptatem rerum in eos.', 'Зинаида Владимирович Носов', '1982-03-08', 'Петров, Николаев and Колесников', 'in', 'tempore', 1, '56');
INSERT INTO `Books` (`bk_id`, `bk_name`, `bk_author`, `bk_publishYear`, `bk_publiser`, `bk_genre`, `bk_coverType`, `bk_availiability`, `bk_pagesCount`) VALUES (6, 'Reprehenderit consequatur harum iure eos harum.', 'Анфиса Дмитриевич Денисов', '2007-02-16', 'Маслов and Sons', 'modi', 'illum', 0, '658');
INSERT INTO `Books` (`bk_id`, `bk_name`, `bk_author`, `bk_publishYear`, `bk_publiser`, `bk_genre`, `bk_coverType`, `bk_availiability`, `bk_pagesCount`) VALUES (7, 'Maiores fugiat reiciendis rem.', 'Зиновьев Марина Евгеньевич', '2017-12-12', 'Князев-Морозов', 'libero', 'ut', 1, '860');
INSERT INTO `Books` (`bk_id`, `bk_name`, `bk_author`, `bk_publishYear`, `bk_publiser`, `bk_genre`, `bk_coverType`, `bk_availiability`, `bk_pagesCount`) VALUES (8, 'Facilis et est laborum totam similique omnis.', 'Потапов Назар Борисович', '1994-05-09', 'Гуляев-Гусев', 'quisquam', 'eius', 0, '574');
INSERT INTO `Books` (`bk_id`, `bk_name`, `bk_author`, `bk_publishYear`, `bk_publiser`, `bk_genre`, `bk_coverType`, `bk_availiability`, `bk_pagesCount`) VALUES (9, 'Quod aspernatur asperiores ut omnis.', 'Искра Борисович Сафонов', '2008-09-03', 'Кондратьев Ltd', 'placeat', 'dolorum', 1, '735');



#
# TABLE STRUCTURE FOR: User
#

CREATE TABLE `User` (
  `us_id` tinyint(4) NOT NULL,
  `us_name` text COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `us_notes` text COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`us_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

INSERT INTO `User` (`us_id`, `us_name`, `us_notes`) VALUES (0, 'Спартак Сергеевич Уваров', 'Qui eveniet corporis alias veritatis quia maiores. Aut eius et veritatis quisquam dolor. Quia eum animi et consequatur officiis quaerat.');
INSERT INTO `User` (`us_id`, `us_name`, `us_notes`) VALUES (1, 'Овчинников Зоя Львович', 'Natus nihil odit omnis. Distinctio cumque repellendus odio illo molestias ut. Cupiditate molestiae aut cum quam. Laborum voluptatem rem autem ex et.');
INSERT INTO `User` (`us_id`, `us_name`, `us_notes`) VALUES (2, 'Юдин Марта Романович', 'Asperiores dicta repellendus est minus nihil in tenetur. Dicta nihil nobis atque hic nesciunt voluptas. Quo mollitia eveniet nisi veritatis cum omnis iste sint. Repellendus architecto et explicabo.');
INSERT INTO `User` (`us_id`, `us_name`, `us_notes`) VALUES (3, 'Илларион Львович Беляев', 'Voluptas veniam tempore natus qui. Aut ea inventore numquam adipisci. Laboriosam et velit est asperiores aut omnis earum veniam.');
INSERT INTO `User` (`us_id`, `us_name`, `us_notes`) VALUES (4, 'гордей Борисович Фадеев', 'Qui quam et laborum. Molestiae est distinctio odio ab. Omnis commodi dolorum rerum voluptatem et. Velit pariatur sit quasi molestias officiis nisi.');
INSERT INTO `User` (`us_id`, `us_name`, `us_notes`) VALUES (5, 'Анна Владимирович Князев', 'Consequuntur recusandae autem tempora ut. Aut quia officiis eum at exercitationem reprehenderit quia. Sequi quibusdam quam fugit quasi vel.');
INSERT INTO `User` (`us_id`, `us_name`, `us_notes`) VALUES (6, 'Панов Вера Андреевич', 'Aut quo molestiae velit facere sint doloribus. Molestias molestias eligendi id aut consequatur. Voluptatum distinctio eaque ea natus omnis natus voluptas enim.');
INSERT INTO `User` (`us_id`, `us_name`, `us_notes`) VALUES (7, 'Гордеев Алла Дмитриевич', 'Voluptatem cupiditate eos fuga enim fuga saepe. Sint labore doloribus in. Omnis possimus quaerat eos eveniet iure sed. Fugit vero laudantium culpa error nesciunt sapiente soluta autem.');
INSERT INTO `User` (`us_id`, `us_name`, `us_notes`) VALUES (8, 'Герасимов Гавриил Александрович', 'Aliquam quo nisi voluptatem quibusdam soluta sequi doloribus molestiae. Et aperiam amet fugit eos. Sint ut optio perferendis velit laboriosam velit. Placeat consequatur sapiente qui illum ex ut et.');
INSERT INTO `User` (`us_id`, `us_name`, `us_notes`) VALUES (9, 'Денисов Ирина Иванович', 'Sapiente ut voluptas ipsa repellendus ut. Consequatur cum qui et tenetur consequatur. Ut molestias nemo in id sunt eligendi. Laudantium commodi non quasi qui.');




#
# TABLE STRUCTURE FOR: BooksUser
#


CREATE TABLE `BooksUser` (
  `us_id` tinyint(4) NOT NULL,
  `bk_id` tinyint(4) NOT NULL,
  `bu_extradictionDate` date DEFAULT NULL,
  `bu_returnDate` date DEFAULT NULL,
  `bu_note` text COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`us_id`,`bk_id`),
  KEY `FK_Take` (`bk_id`),
  CONSTRAINT `FK_Take` FOREIGN KEY (`bk_id`) REFERENCES `Books` (`bk_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_Write` FOREIGN KEY (`us_id`) REFERENCES `User` (`us_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

#
# TABLE STRUCTURE FOR: ForeignBooks
#


CREATE TABLE `ForeignBooks` (
  `bk_id` tinyint(4) NOT NULL,
  `fb_id` tinyint(4) NOT NULL,
  `bk_name` char(10) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `bk_author` text COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `bk_publishYear` date DEFAULT NULL,
  `bk_publiser` text COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `bk_genre` text COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `bk_coverType` text COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `bk_availiability` tinyint(1) DEFAULT NULL,
  `bk_pagesCount` decimal(10,0) DEFAULT NULL,
  `fb_originalLanguage` text COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `fb_license` text COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`bk_id`,`fb_id`),
  CONSTRAINT `FK_Inheritance_2` FOREIGN KEY (`bk_id`) REFERENCES `Books` (`bk_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

INSERT INTO `ForeignBooks` (`bk_id`, `fb_id`, `bk_name`, `bk_author`, `bk_publishYear`, `bk_publiser`, `bk_genre`, `bk_coverType`, `bk_availiability`, `bk_pagesCount`, `fb_originalLanguage`, `fb_license`) VALUES (0, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'blanditiis', 'Захаров and Sons');
INSERT INTO `ForeignBooks` (`bk_id`, `fb_id`, `bk_name`, `bk_author`, `bk_publishYear`, `bk_publiser`, `bk_genre`, `bk_coverType`, `bk_availiability`, `bk_pagesCount`, `fb_originalLanguage`, `fb_license`) VALUES (0, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'tempora', 'Евдокимов, Егоров and Авдеев');
INSERT INTO `ForeignBooks` (`bk_id`, `fb_id`, `bk_name`, `bk_author`, `bk_publishYear`, `bk_publiser`, `bk_genre`, `bk_coverType`, `bk_availiability`, `bk_pagesCount`, `fb_originalLanguage`, `fb_license`) VALUES (0, 3, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'quia', 'Фёдоров LLC');
INSERT INTO `ForeignBooks` (`bk_id`, `fb_id`, `bk_name`, `bk_author`, `bk_publishYear`, `bk_publiser`, `bk_genre`, `bk_coverType`, `bk_availiability`, `bk_pagesCount`, `fb_originalLanguage`, `fb_license`) VALUES (0, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'excepturi', 'Емельянов PLC');
INSERT INTO `ForeignBooks` (`bk_id`, `fb_id`, `bk_name`, `bk_author`, `bk_publishYear`, `bk_publiser`, `bk_genre`, `bk_coverType`, `bk_availiability`, `bk_pagesCount`, `fb_originalLanguage`, `fb_license`) VALUES (0, 8, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'corrupti', 'Кондратьев, Родионов and Горбунов');


#
# TABLE STRUCTURE FOR: IllustratedBook
#


CREATE TABLE `IllustratedBook` (
  `bk_id` tinyint(4) NOT NULL,
  `ib_id` tinyint(4) NOT NULL,
  `bk_name` text COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `bk_author` text COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `bk_publishYear` date DEFAULT NULL,
  `bk_publiser` text COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `bk_genre` text COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `bk_coverType` text COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `bk_availiability` tinyint(1) DEFAULT NULL,
  `bk_pagesCount` decimal(10,0) DEFAULT NULL,
  `ib_illustrator` text COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `ib_colored` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`bk_id`,`ib_id`),
  CONSTRAINT `FK_Inheritance_1` FOREIGN KEY (`bk_id`) REFERENCES `Books` (`bk_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

INSERT INTO `IllustratedBook` (`bk_id`, `ib_id`, `bk_name`, `bk_author`, `bk_publishYear`, `bk_publiser`, `bk_genre`, `bk_coverType`, `bk_availiability`, `bk_pagesCount`, `ib_illustrator`, `ib_colored`) VALUES (0, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'Комиссаров Нина Алексеевич', 1);
INSERT INTO `IllustratedBook` (`bk_id`, `ib_id`, `bk_name`, `bk_author`, `bk_publishYear`, `bk_publiser`, `bk_genre`, `bk_coverType`, `bk_availiability`, `bk_pagesCount`, `ib_illustrator`, `ib_colored`) VALUES (0, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'Носов Эльвира Романович', 0);
INSERT INTO `IllustratedBook` (`bk_id`, `ib_id`, `bk_name`, `bk_author`, `bk_publishYear`, `bk_publiser`, `bk_genre`, `bk_coverType`, `bk_availiability`, `bk_pagesCount`, `ib_illustrator`, `ib_colored`) VALUES (0, 2, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'кузьма Львович Панов', 0);
INSERT INTO `IllustratedBook` (`bk_id`, `ib_id`, `bk_name`, `bk_author`, `bk_publishYear`, `bk_publiser`, `bk_genre`, `bk_coverType`, `bk_availiability`, `bk_pagesCount`, `ib_illustrator`, `ib_colored`) VALUES (0, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'Пестов Злата Романович', 0);
INSERT INTO `IllustratedBook` (`bk_id`, `ib_id`, `bk_name`, `bk_author`, `bk_publishYear`, `bk_publiser`, `bk_genre`, `bk_coverType`, `bk_availiability`, `bk_pagesCount`, `ib_illustrator`, `ib_colored`) VALUES (0, 8, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'Ксения Борисович Пахомов', 0);


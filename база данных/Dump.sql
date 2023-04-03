CREATE DATABASE  IF NOT EXISTS `oborot_si` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci */;
USE `oborot_si`;
-- MySQL dump 10.13  Distrib 8.0.31, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: oborot_si
-- ------------------------------------------------------
-- Server version	5.7.39

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `graphic`
--

DROP TABLE IF EXISTS `graphic`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `graphic` (
  `id_graphic` int(11) NOT NULL AUTO_INCREMENT,
  `id_si` int(11) NOT NULL,
  `periodichnost` tinyint(4) NOT NULL,
  `mesto_proved_old` int(11) NOT NULL,
  `data` date NOT NULL,
  `mesto_proved_new` int(11) NOT NULL,
  PRIMARY KEY (`id_graphic`),
  KEY `FK_graphic_si_card` (`id_si`),
  KEY `mesto_proved_old` (`mesto_proved_old`),
  KEY `mesto_proved_new` (`mesto_proved_new`),
  CONSTRAINT `FK_graphic_mesto_provedeni` FOREIGN KEY (`mesto_proved_new`) REFERENCES `mesto_provedenia` (`mesto_provedenia_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_graphic_mesto_provedenia` FOREIGN KEY (`mesto_proved_old`) REFERENCES `mesto_provedenia` (`mesto_provedenia_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_graphic_si_card` FOREIGN KEY (`id_si`) REFERENCES `si_card` (`id_si`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=32 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `graphic`
--

LOCK TABLES `graphic` WRITE;
/*!40000 ALTER TABLE `graphic` DISABLE KEYS */;
INSERT INTO `graphic` VALUES (3,271,12,0,'2001-01-20',0),(4,272,18,0,'2012-01-20',0),(5,273,24,0,'2021-01-20',0),(6,274,36,0,'2010-01-20',0),(7,275,48,0,'2004-02-20',0),(8,276,6,0,'2017-02-20',0),(9,277,12,0,'2009-03-20',0),(10,278,12,0,'2009-03-20',0),(11,279,12,0,'2010-03-20',0),(12,271,12,0,'2013-06-20',0),(13,271,12,0,'2006-12-20',0),(15,350,12,0,'2008-12-20',0),(16,351,12,0,'2008-12-20',0),(17,353,12,0,'2015-03-20',0),(29,271,36,3,'2026-03-28',2),(30,359,12,8,'2024-03-31',4),(31,359,24,2,'2025-03-31',8);
/*!40000 ALTER TABLE `graphic` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `journals`
--

DROP TABLE IF EXISTS `journals`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `journals` (
  `id_raboti` int(11) NOT NULL,
  `data` date NOT NULL,
  `id_si` int(11) NOT NULL,
  `zakluchenie` varchar(30) COLLATE utf8mb4_unicode_ci NOT NULL,
  `vid_rabot` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`id_raboti`),
  KEY `FK_journal_kalibrovki_si_card` (`id_si`),
  KEY `FK_journal_kalibrovki_zakluchenie` (`zakluchenie`),
  KEY `FK_journals_vid_rabot` (`vid_rabot`),
  CONSTRAINT `FK_journal_kalibrovki_si_card` FOREIGN KEY (`id_si`) REFERENCES `si_card` (`id_si`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_journal_kalibrovki_zakluchenie` FOREIGN KEY (`zakluchenie`) REFERENCES `zakluchenie` (`zakluchenie`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_journals_vid_rabot` FOREIGN KEY (`vid_rabot`) REFERENCES `vid_rabot` (`vid_rabot`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `journals`
--

LOCK TABLES `journals` WRITE;
/*!40000 ALTER TABLE `journals` DISABLE KEYS */;
INSERT INTO `journals` VALUES (1,'2007-12-20',271,'Годен','Калибровка'),(2,'2007-12-20',271,'Годен','Поверка'),(3,'2006-12-20',274,'Брак','Калибровка'),(4,'2007-12-20',274,'Годен','Поверка'),(5,'2007-12-20',286,'Годен','Калибровка'),(6,'2009-12-20',349,'Брак','Поверка'),(7,'2009-12-20',350,'Брак','Поверка'),(8,'2009-12-20',351,'Годен','Поверка'),(9,'2024-12-20',330,'Годен','Проверка'),(10,'2024-12-20',330,'Годен','Калибровка'),(11,'2024-12-20',330,'Брак','Калибровка'),(12,'2023-03-29',357,'Брак','Поверка'),(13,'2023-03-25',357,'Брак','Калибровка'),(14,'2023-03-17',357,'Брак','Проверка'),(15,'2023-03-29',291,'Годен','Проверка'),(16,'2023-03-29',271,'Годен','Калибровка'),(17,'2023-04-01',359,'Годен','Калибровка');
/*!40000 ALTER TABLE `journals` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mesto_provedenia`
--

DROP TABLE IF EXISTS `mesto_provedenia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `mesto_provedenia` (
  `mesto_provedenia_id` int(11) NOT NULL AUTO_INCREMENT,
  `mesto_provedenia` varchar(150) COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`mesto_provedenia_id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mesto_provedenia`
--

LOCK TABLES `mesto_provedenia` WRITE;
/*!40000 ALTER TABLE `mesto_provedenia` DISABLE KEYS */;
INSERT INTO `mesto_provedenia` VALUES (1,'ФБУ «Ростест-Москва»'),(2,'ЗАО «ПриСТ»'),(3,'ООО «НПФ АДСилаб»'),(4,'ФГБУ \"ГНМЦ\"\" МО\"'),(5,'БелГИМ'),(6,'ФГУП «ВННИМС»'),(7,'ООО НПК «Эталон-Тест»'),(8,'РФЯЦ-ВНИИТФ');
/*!40000 ALTER TABLE `mesto_provedenia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `naimenovanie_si`
--

DROP TABLE IF EXISTS `naimenovanie_si`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `naimenovanie_si` (
  `naimenovanie` varchar(200) COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`naimenovanie`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `naimenovanie_si`
--

LOCK TABLES `naimenovanie_si` WRITE;
/*!40000 ALTER TABLE `naimenovanie_si` DISABLE KEYS */;
INSERT INTO `naimenovanie_si` VALUES ('Ампервольтметр'),('Амперметр'),('Вольтметр'),('Вольтмиллиамперметр'),('Генератор'),('Измеритель'),('Измеритель сопр. изоляции'),('Измеритель температуры'),('Источник питания'),('Комбинированный прибор'),('Магазин сопротивлений'),('Мегаомметр'),('Микроампервольтметр'),('Микроамперметр'),('Микроомметр'),('Миллиамперметр'),('Милливольтметр'),('Мост'),('Мультиметр цифровой'),('Омметр'),('Осциллограф'),('Фазометр'),('Частотомер'),('Электросекундомер');
/*!40000 ALTER TABLE `naimenovanie_si` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prinadlejnost`
--

DROP TABLE IF EXISTS `prinadlejnost`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `prinadlejnost` (
  `prinadlejnost` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`prinadlejnost`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prinadlejnost`
--

LOCK TABLES `prinadlejnost` WRITE;
/*!40000 ALTER TABLE `prinadlejnost` DISABLE KEYS */;
INSERT INTO `prinadlejnost` VALUES ('Отдел 117'),('Отдел 131'),('Отдел 65'),('Цех № 10'),('Цех № 9');
/*!40000 ALTER TABLE `prinadlejnost` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `protocol`
--

DROP TABLE IF EXISTS `protocol`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `protocol` (
  `id_protocol` int(11) NOT NULL,
  `id_si` int(11) NOT NULL,
  `primechanie` longtext COLLATE utf8mb4_unicode_ci,
  `id_sotrudnik` int(11) NOT NULL,
  PRIMARY KEY (`id_protocol`),
  KEY `FK_protocol_sotrudnik` (`id_sotrudnik`),
  KEY `FK_protocol_si_card` (`id_si`),
  CONSTRAINT `FK_protocol_si_card` FOREIGN KEY (`id_si`) REFERENCES `si_card` (`id_si`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_protocol_sotrudnik` FOREIGN KEY (`id_sotrudnik`) REFERENCES `sotrudnik` (`id_sotrudnik`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `protocol`
--

LOCK TABLES `protocol` WRITE;
/*!40000 ALTER TABLE `protocol` DISABLE KEYS */;
INSERT INTO `protocol` VALUES (1,271,'Есть дефект на устройстве не сказывающися в его работе',8),(2,271,'',11),(3,351,'Есть дефект на самом устройстве но не влияющий на работу устройства',10),(4,350,'При измерении выдает ошибку',10),(5,349,'Есть дефект не влияющий на работу устройства',10),(15,291,'',8),(16,271,'',8),(17,359,'Все хорошо',5);
/*!40000 ALTER TABLE `protocol` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `role`
--

DROP TABLE IF EXISTS `role`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `role` (
  `role` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`role`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `role`
--

LOCK TABLES `role` WRITE;
/*!40000 ALTER TABLE `role` DISABLE KEYS */;
INSERT INTO `role` VALUES ('Администратор'),('Сотрудник');
/*!40000 ALTER TABLE `role` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `si_card`
--

DROP TABLE IF EXISTS `si_card`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `si_card` (
  `id_si` int(11) NOT NULL AUTO_INCREMENT,
  `naimenovanie` varchar(200) COLLATE utf8mb4_unicode_ci NOT NULL,
  `tip` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `firma` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `diapazon` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `invent_nomer` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `zavod_nomer` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `etalon` tinyint(1) NOT NULL,
  `sostoyanie` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `komplectacia` longtext COLLATE utf8mb4_unicode_ci NOT NULL,
  `opisanie` longtext COLLATE utf8mb4_unicode_ci NOT NULL,
  `prinadlejnost` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`id_si`),
  KEY `FK_si_card_sostoyanie` (`sostoyanie`),
  KEY `FK_si_card_naimenovanie_si` (`naimenovanie`),
  KEY `FK_si_card_prinadlejnost` (`prinadlejnost`),
  CONSTRAINT `FK_si_card_naimenovanie_si` FOREIGN KEY (`naimenovanie`) REFERENCES `naimenovanie_si` (`naimenovanie`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_si_card_prinadlejnost` FOREIGN KEY (`prinadlejnost`) REFERENCES `prinadlejnost` (`prinadlejnost`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_si_card_sostoyanie` FOREIGN KEY (`sostoyanie`) REFERENCES `sostoyanie` (`sostoyanie`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=360 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `si_card`
--

LOCK TABLES `si_card` WRITE;
/*!40000 ALTER TABLE `si_card` DISABLE KEYS */;
INSERT INTO `si_card` VALUES (271,'Амперметр','ЛМ - 1','Textronix','100 mV - 500V ± 1,5','0','8827',0,'В эксплуатации','Прибор, сетевой шнур, руководство по эксплуатации','Красивый','Отдел 65'),(272,'Микроамперметр','М-1200','Gwinstek','101 mV - 500V ± 1,5','5982','66463',0,'На проверке','Прибор, сетевой шнур, руководство по эксплуатации','Точный','Отдел 131'),(273,'Миллиамперметр','ЛМ - 1','РИП-Импульс','102 mV - 500V ± 1,5','6145','1783',0,'На калибровке','Прибор, сетевой шнур, руководство по эксплуатации','Лучший','Отдел 117'),(274,'Вольтмиллиамперметр','ЛМ-1','Textronix','103 mV - 500V ± 1,5','0','9314',0,'В поверке','Прибор, сетевой шнур, руководство по эксплуатации','Красивый','Цех № 9'),(275,'Ампервольтметр','М - 231','Gwinstek','104 mV - 500V ± 1,5','8698','350',0,'В ремонте','Прибор, сетевой шнур, руководство по эксплуатации','Точный','Цех № 10'),(276,'Микроампервольтметр','М-1106','РИП-Импульс','105 mV - 500V ± 1,5','30481','6126',0,'Брак','Прибор, сетевой шнур, руководство по эксплуатации','Лучший','Отдел 65'),(277,'Вольтметр','ЛМ – 1','Textronix','106 mV - 500V ± 1,5','0','8907',1,'В эксплуатации','Прибор, сетевой шнур, руководство по эксплуатации','Средство измерения (эталон)','Отдел 131'),(278,'Милливольтметр','В 3 - 38','Gwinstek','107 mV - 500V ± 1,5','30868','2206',1,'На проверке','Прибор, сетевой шнур, руководство по эксплуатации','Средство измерения (эталон)','Отдел 117'),(279,'Вольтметр','В7 – 16А','РИП-Импульс','108 mV - 500V ± 1,5','31795','К07268',1,'На калибровке','Прибор, сетевой шнур, руководство по эксплуатации','Средство измерения (эталон)','Цех № 9'),(280,'Вольтметр','В 7 – 22А','Textronix','109 mV - 500V ± 1,5','31087','7292',0,'В поверке','Прибор, сетевой шнур, руководство по эксплуатации','Красивый','Отдел 131'),(281,'Вольтметр','В 7 - 38','Gwinstek','110 mV - 500V ± 1,5','31424','4419',0,'В ремонте','Прибор, сетевой шнур, руководство по эксплуатации','Точный','Отдел 65'),(282,'Вольтметр','В 7 – 40 / 4','РИП-Импульс','111 mV - 500V ± 1,5','31663','190690',0,'Брак','Прибор, сетевой шнур, руководство по эксплуатации','Лучший','Отдел 131'),(283,'Вольтметр','В7-78/2','Textronix','112 mV - 500V ± 1,5','4470234','TW00026449',1,'В эксплуатации','Прибор, сетевой шнур, руководство по эксплуатации','Красивый','Отдел 117'),(284,'Комбинированный прибор','Ц 4352','Gwinstek','113 mV - 500V ± 1,5','8828','278553',0,'На проверке','Прибор, сетевой шнур, руководство по эксплуатации','Точный','Цех № 9'),(285,'Мультиметр цифровой','GDM-8245','РИП-Импульс','114 mV - 500V ± 1,5','4470297','GCS814548',0,'На калибровке','Прибор, сетевой шнур, руководство по эксплуатации','Лучший','Цех № 10'),(286,'Мультиметр цифровой','Agilent 34401A','Textronix','115 mV - 500V ± 1,5','0','MY45032004',0,'В поверке','Прибор, сетевой шнур, руководство по эксплуатации','Красивый','Отдел 65'),(287,'Мультиметр цифровой','MY-63','Gwinstek','116 mV - 500V ± 1,5','0','MBEB091091',0,'В ремонте','Прибор, сетевой шнур, руководство по эксплуатации','Точный','Отдел 131'),(288,'Мультиметр цифровой','MY-67','РИП-Импульс','117 mV - 500V ± 1,5','0','11070091929',0,'Брак','Прибор, сетевой шнур, руководство по эксплуатации','Лучший','Отдел 117'),(289,'Мультиметр цифровой','Fluke 17В+','Textronix','118 mV - 500V ± 1,5','4470232','36871524WS',0,'В эксплуатации','Прибор, сетевой шнур, руководство по эксплуатации','Красивый','Цех № 9'),(290,'Мультиметр цифровой','М-830','Gwinstek','119 mV - 500V ± 1,5','0','41V',0,'На проверке','Прибор, сетевой шнур, руководство по эксплуатации','Точный','Цех № 10'),(291,'Мультиметр цифровой','M-838','РИП-Импульс','120 mV - 500V ± 1,5','0','1',0,'На калибровке','Прибор, сетевой шнур, руководство по эксплуатации','Лучший','Отдел 65'),(292,'Мультиметр цифровой','DT-830B','Textronix','121 mV - 500V ± 1,5','0','1080212673',0,'В поверке','Прибор, сетевой шнур, руководство по эксплуатации','Красивый','Отдел 131'),(293,'Мультиметр цифровой','В7-61','Gwinstek','122 mV - 500V ± 1,5','4470240','5737',0,'В ремонте','Прибор, сетевой шнур, руководство по эксплуатации','Точный','Отдел 117'),(294,'Мультиметр цифровой',' В7-80','РИП-Импульс','123 mV - 500V ± 1,5','4470251','1677',1,'Брак','Прибор, сетевой шнур, руководство по эксплуатации','Средство измерения (эталон)','Цех № 9'),(295,'Мультиметр цифровой','АРРА-73','Textronix','124 mV - 500V ± 1,5','4470025','35912887',1,'В эксплуатации','Прибор, сетевой шнур, руководство по эксплуатации','Средство измерения (эталон)','Цех № 10'),(296,'Мультиметр цифровой','АРРА-73','Gwinstek','125 mV - 500V ± 1,5','','',0,'На проверке','Прибор, сетевой шнур, руководство по эксплуатации','Точный','Отдел 65'),(297,'Источник питания','Б1 – 9','Textronix','139 mV - 500V ± 1,5','0','1071199',0,'В поверке','Прибор, сетевой шнур, руководство по эксплуатации','Красивый','Цех № 10'),(298,'Источник питания','Б5 - 7','Gwinstek','140 mV - 500V ± 1,5','0','8614',0,'В ремонте','Прибор, сетевой шнур, руководство по эксплуатации','Точный','Отдел 65'),(299,'Источник питания','Б5-43А','РИП-Импульс','141 mV - 500V ± 1,5','31541','3522',1,'Брак','Прибор, сетевой шнур, руководство по эксплуатации','Средство измерения (эталон)','Отдел 131'),(300,'Источник питания','Б5-44А','Textronix','142 mV - 500V ± 1,5','31732','15836',1,'В эксплуатации','Прибор, сетевой шнур, руководство по эксплуатации','Средство измерения (эталон)','Отдел 117'),(301,'Источник питания','Б5 - 45','Gwinstek','143 mV - 500V ± 1,5','31739','13038',1,'На проверке','Прибор, сетевой шнур, руководство по эксплуатации','Средство измерения (эталон)','Цех № 9'),(302,'Источник питания','Б5 - 45А','РИП-Импульс','144 mV - 500V ± 1,5','31740','12983',0,'На калибровке','Прибор, сетевой шнур, руководство по эксплуатации','Лучший','Цех № 10'),(303,'Источник питания','Б 5 - 47','Textronix','145 mV - 500V ± 1,5','31310','7635',0,'В поверке','Прибор, сетевой шнур, руководство по эксплуатации','Красивый','Отдел 65'),(304,'Источник питания','Б5 - 48','Gwinstek','146 mV - 500V ± 1,5','31393','7254',0,'В ремонте','Прибор, сетевой шнур, руководство по эксплуатации','Точный','Отдел 131'),(305,'Источник питания','Б5 - 70','РИП-Импульс','147 mV - 500V ± 1,5','31799','3389107',0,'Брак','Прибор, сетевой шнур, руководство по эксплуатации','Лучший','Отдел 117'),(306,'Источник питания','Б5 - 71','Textronix','148 mV - 500V ± 1,5','0','2101024',0,'В эксплуатации','Прибор, сетевой шнур, руководство по эксплуатации','Красивый','Цех № 9'),(307,'Источник питания','Б5-71/м','Gwinstek','149 mV - 500V ± 1,5','4470089','80456',0,'На проверке','Прибор, сетевой шнур, руководство по эксплуатации','Точный','Цех № 10'),(308,'Источник питания','Б5-88','РИП-Импульс','150 mV - 500V ± 1,5','4470238','216',0,'На калибровке','Прибор, сетевой шнур, руководство по эксплуатации','Лучший','Отдел 65'),(309,'Источник питания','ТЕС - 14','Textronix','151 mV - 500V ± 1,5','30743','226',1,'В поверке','Прибор, сетевой шнур, руководство по эксплуатации','Средство измерения (эталон)','Отдел 131'),(310,'Источник питания','ТЕС-18','Gwinstek','152 mV - 500V ± 1,5','31189','815',0,'В ремонте','Прибор, сетевой шнур, руководство по эксплуатации','Точный','Отдел 117'),(311,'Источник питания','Xantrex XDC 100-60HV','РИП-Импульс','153 mV - 500V ± 1,5','4470063','E 00132228',0,'Брак','Прибор, сетевой шнур, руководство по эксплуатации','Лучший','Цех № 9'),(312,'Источник питания','GPC-1850D','Textronix','154 mV - 500V ± 1,5','44470034','Е 852854',0,'В эксплуатации','Прибор, сетевой шнур, руководство по эксплуатации','Красивый','Цех № 10'),(313,'Источник питания','PST-3201','Gwinstek','155 mV - 500V ± 1,5','4470090','B210157',0,'На проверке','Прибор, сетевой шнур, руководство по эксплуатации','Точный','Отдел 65'),(314,'Источник питания','PST-3202','РИП-Импульс','156 mV - 500V ± 1,5','4470088','В 200719',0,'Брак','Прибор, сетевой шнур, руководство по эксплуатации','Лучший','Отдел 131'),(315,'Источник питания','SPS - 3610','Textronix','157 mV - 500V ± 1,5','4470010','D 110401',0,'В поверке','Прибор, сетевой шнур, руководство по эксплуатации','Красивый','Отдел 117'),(316,'Источник питания','SPS - 606','Gwinstek','158 mV - 500V ± 1,5','4470404','GEU860349',0,'В ремонте','Прибор, сетевой шнур, руководство по эксплуатации','Точный','Цех № 9'),(317,'Источник питания','PSH - 3610','РИП-Импульс','159 mV - 500V ± 1,5','0','EI 220981',0,'Брак','Прибор, сетевой шнур, руководство по эксплуатации','Лучший','Цех № 10'),(318,'Источник питания','PSH-73630','Textronix','160 mV - 500V ± 1,5','4470188','EN853197',1,'В эксплуатации','Прибор, сетевой шнур, руководство по эксплуатации','Средство измерения (эталон)','Отдел 65'),(319,'Источник питания','PSH-3630','Gwinstek','161 mV - 500V ± 1,5','4470074','EG220350',0,'На проверке','Прибор, сетевой шнур, руководство по эксплуатации','Точный','Отдел 131'),(320,'Источник питания','PSP-405','РИП-Импульс','162 mV - 500V ± 1,5','4470082','EH141341',0,'На калибровке','Прибор, сетевой шнур, руководство по эксплуатации','Лучший','Отдел 117'),(321,'Источник питания','PSW7 30-108','Textronix','163 mV - 500V ± 1,5','0','GEP142846',1,'В поверке','Прибор, сетевой шнур, руководство по эксплуатации','Средство измерения (эталон)','Цех № 9'),(322,'Измеритель сопр. изоляции','1851 IN','Gwinstek','164 mV - 500V ± 1,5','4470163','1315419',0,'В ремонте','Прибор, сетевой шнур, руководство по эксплуатации','Точный','Цех № 10'),(323,'Измеритель сопр. изоляции','МЕГЕОН 13130','РИП-Импульс','165 mV - 500V ± 1,5','4470407','15056535',0,'Брак','Прибор, сетевой шнур, руководство по эксплуатации','Лучший','Отдел 65'),(324,'Измеритель сопр. изоляции','МЕГЕОН 13121','Textronix','166 mV - 500V ± 1,5','4470410','ИСЗ №1',0,'В эксплуатации','Прибор, сетевой шнур, руководство по эксплуатации','Красивый','Отдел 131'),(325,'Магазин сопротивлений','Р - 33','Gwinstek','167 mV - 500V ± 1,5','8421','27968',0,'На проверке','Прибор, сетевой шнур, руководство по эксплуатации','Точный','Отдел 117'),(326,'Мост','МО – 62','РИП-Импульс','168 mV - 500V ± 1,5','30438','7070',0,'На калибровке','Прибор, сетевой шнур, руководство по эксплуатации','Лучший','Цех № 9'),(327,'Магазин сопротивлений','МСР - 63','Textronix','169 mV - 500V ± 1,5','5849','15224',0,'В поверке','Прибор, сетевой шнур, руководство по эксплуатации','Красивый','Цех № 10'),(328,'Омметр','Ф  410','Gwinstek','170 mV - 500V ± 1,5','8736','3144',0,'В ремонте','Прибор, сетевой шнур, руководство по эксплуатации','Точный','Отдел 65'),(329,'Микроомметр','Ф  415','РИП-Импульс','171 mV - 500V ± 1,5','0','762',0,'Брак','Прибор, сетевой шнур, руководство по эксплуатации','Лучший','Отдел 131'),(330,'Микроомметр','MMR-620','Textronix','172 mV - 500V ± 1,5','0','323285',1,'В эксплуатации','Прибор, сетевой шнур, руководство по эксплуатации','Средство измерения (эталон)','Отдел 117'),(331,'Мегаомметр','Ф  4101','Gwinstek','173 mV - 500V ± 1,5','31169','60994',0,'На проверке','Прибор, сетевой шнур, руководство по эксплуатации','Точный','Цех № 9'),(332,'Мегаомметр','М 1101','РИП-Импульс','174 mV - 500V ± 1,5','6840','507092',0,'На калибровке','Прибор, сетевой шнур, руководство по эксплуатации','Лучший','Цех № 10'),(333,'Измеритель','Ф - 291','Textronix','175 mV - 500V ± 1,5','31285','68',0,'В поверке','Прибор, сетевой шнур, руководство по эксплуатации','Красивый','Отдел 65'),(334,'Частотомер','Ч 3 - 57','Gwinstek','176 mV - 500V ± 1,5','31076','210098',0,'В ремонте','Прибор, сетевой шнур, руководство по эксплуатации','Точный','Отдел 131'),(335,'Фазометр','Ф 2 - 34','РИП-Импульс','177 mV - 500V ± 1,5','4470366','2223',0,'Брак','Прибор, сетевой шнур, руководство по эксплуатации','Лучший','Отдел 117'),(336,'Генератор','LCROY','Textronix','178 mV - 500V ± 1,5','0','LCRY3602C00341',0,'В эксплуатации','Прибор, сетевой шнур, руководство по эксплуатации','Красивый','Цех № 9'),(337,'Генератор','SMY02','Gwinstek','179 mV - 500V ± 1,5','4470058','8375771013',0,'На проверке','Прибор, сетевой шнур, руководство по эксплуатации','Точный','Цех № 10'),(338,'Генератор','FCC-TG-115A','РИП-Импульс','180 mV - 500V ± 1,5','0','111126',1,'На калибровке','Прибор, сетевой шнур, руководство по эксплуатации','Средство измерения (эталон)','Отдел 65'),(339,'Генератор','Г 3 -15','Textronix','181 mV - 500V ± 1,5','31081','12148',1,'В поверке','Прибор, сетевой шнур, руководство по эксплуатации','Средство измерения (эталон)','Отдел 131'),(340,'Генератор','Г 3 - 112','Gwinstek','182 mV - 500V ± 1,5','31469','29733',1,'В ремонте','Прибор, сетевой шнур, руководство по эксплуатации','Средство измерения (эталон)','Отдел 117'),(341,'Генератор','Г3-33','РИП-Импульс','183 mV - 500V ± 1,5','0','45241',0,'Брак','Прибор, сетевой шнур, руководство по эксплуатации','Лучший','Цех № 9'),(342,'Генератор','Г 6 - 27','Textronix','184 mV - 500V ± 1,5','31380','10504',0,'В эксплуатации','Прибор, сетевой шнур, руководство по эксплуатации','Красивый','Цех № 10'),(343,'Генератор','Г 6 - 37','Gwinstek','185 mV - 500V ± 1,5','0','31242',1,'На проверке','Прибор, сетевой шнур, руководство по эксплуатации','Средство измерения (эталон)','Отдел 65'),(344,'Осциллограф','С1 - 83','РИП-Импульс','186 mV - 500V ± 1,5','31254','С 04530',0,'На калибровке','Прибор, сетевой шнур, руководство по эксплуатации','Лучший','Отдел 131'),(345,'Осциллограф','С1-93','Textronix','187 mV - 500V ± 1,5','31682','К04810',1,'В поверке','Прибор, сетевой шнур, руководство по эксплуатации','Средство измерения (эталон)','Отдел 117'),(346,'Измеритель температуры','Магистр','Gwinstek','188 mV - 500V ± 1,5','7700833','201927',0,'В ремонте','Прибор, сетевой шнур, руководство по эксплуатации','Точный','Цех № 9'),(347,'Электросекундомер','ПВ – 53Л','РИП-Импульс','189 mV - 500V ± 1,5','0','5305614',0,'Брак','Прибор, сетевой шнур, руководство по эксплуатации','Лучший','Цех № 10'),(348,'Микроампервольтметр','Аппа 4012','Textronix','106 mV - 500V ± 1,5','111','111',1,'На складе','Прибор, сетевой шнур, руководство по эксплуатации','Средство измерения (эталон)','Отдел 117'),(349,'Мультиметр цифровой','GDM-8245','РИП-Импульс','114 mV - 500V ± 1,5','1111','1111',0,'В поверке','Устройство, шнур','Замечательный','Отдел 65'),(350,'Генератор','LCROY','Textronix','178 mV - 500V ± 1,5','2222','2222',0,'В поверке','Устройство','Замечательный','Отдел 65'),(351,'Источник питания','Б1 – 9','Textronix','139 mV - 500V ± 1,5','3333','3333',0,'В эксплуатации','Устройство, шнур','Замечательный','Отдел 65'),(352,'Вольтмиллиамперметр','М - 231','Textronix','100 mV - 500V ± 1,5','0','12019',1,'В ремонте','Прибор, сетевой шнур, руководство по эксплуатации','Средство измерения (эталон)','Отдел 65'),(353,'Источник питания','А-1214-ТИ','Textronix','139 mV - 500V ± 1,5','0','1071199',0,'Брак','Прибор, сетевой шнур, руководство по эксплуатации','Не работающий','Цех № 10'),(354,'Амперметр','ЛМ - 1','Textronix','100 mV - 500V ± 1,5','123123','1234567',1,'На проверке','Прибор, сетевой шнур,\nруководство по эксплуатации','Красивый','Отдел 131'),(355,'Амперметр','ЛМ - 1','Textronix','100 mV - 500V ± 1,5','123123','1234567',1,'На проверке','Прибор, сетевой шнур,\nруководство по эксплуатации','Красивый','Отдел 131'),(356,'Мост','В 7 – 40 / 4','РИП-Импульс','110 mV - 500V ± 1,5','666444','12ee33',1,'В ремонте','sdsd','dsdsd','Цех № 10'),(357,'Омметр','С1 - 83','РИП-Импульс','176 mV - 500V ± 1,5','14062209','5778749185',1,'В эксплуатации','Шнур, вилка','Шикарненький','Отдел 131'),(358,'Источник питания','В 7 – 22А','Textronix','109 mV - 500V ± 1,5','31087','729290',0,'В поверке','Прибор, сетевой шнур, руководство по эксплуатации','Красивый','Отдел 131'),(359,'Измеритель температуры','R900','Ozon','103 mV - 500V ± 1,5','1406','2209',1,'На калибровке','Прибор','Самый идеальный','Отдел 117');
/*!40000 ALTER TABLE `si_card` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sostoyanie`
--

DROP TABLE IF EXISTS `sostoyanie`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sostoyanie` (
  `sostoyanie` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`sostoyanie`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sostoyanie`
--

LOCK TABLES `sostoyanie` WRITE;
/*!40000 ALTER TABLE `sostoyanie` DISABLE KEYS */;
INSERT INTO `sostoyanie` VALUES ('Брак'),('В поверке'),('В ремонте'),('В эксплуатации'),('На калибровке'),('На проверке'),('На складе');
/*!40000 ALTER TABLE `sostoyanie` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sotrudnik`
--

DROP TABLE IF EXISTS `sotrudnik`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sotrudnik` (
  `id_sotrudnik` int(11) NOT NULL,
  `surname` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `name` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `patronymic` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `date_attestacia` date DEFAULT NULL,
  `login` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  `password` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  `role` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`id_sotrudnik`),
  KEY `FK_sotrudnik_role` (`role`),
  CONSTRAINT `FK_sotrudnik_role` FOREIGN KEY (`role`) REFERENCES `role` (`role`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sotrudnik`
--

LOCK TABLES `sotrudnik` WRITE;
/*!40000 ALTER TABLE `sotrudnik` DISABLE KEYS */;
INSERT INTO `sotrudnik` VALUES (5,'Соловей','Анастасия','Александровна','2022-06-14','Nastya','14062209','Администратор'),(6,'Фильченков','Роман','Александрович','2019-09-22','Lololowka','1111','Сотрудник'),(7,'Лебедкина','Мария','Алексеевна','2020-04-12','Maria','2222','Сотрудник'),(8,'Пагавян','Леонтий','Николаевич','2015-01-30','a1234','1111','Сотрудник'),(9,'Чекмезов','Никита','Егорович','2003-09-10','a2345','2222','Сотрудник'),(10,'Кондратюк','Анита','Владимировна','2023-02-23','a3456','3333','Сотрудник'),(11,'Недрожанов','Павел','Савельевич','2022-11-16','a4567','4444','Сотрудник'),(12,'Селезненко','Зоя','Павловна','2022-03-08','a5678','5555','Сотрудник'),(13,'Демина','Елена',NULL,'2017-05-11','Demina','6666','Сотрудник');
/*!40000 ALTER TABLE `sotrudnik` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vid_rabot`
--

DROP TABLE IF EXISTS `vid_rabot`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `vid_rabot` (
  `vid_rabot` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`vid_rabot`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vid_rabot`
--

LOCK TABLES `vid_rabot` WRITE;
/*!40000 ALTER TABLE `vid_rabot` DISABLE KEYS */;
INSERT INTO `vid_rabot` VALUES ('Калибровка'),('Поверка'),('Проверка');
/*!40000 ALTER TABLE `vid_rabot` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `zakluchenie`
--

DROP TABLE IF EXISTS `zakluchenie`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `zakluchenie` (
  `zakluchenie` varchar(30) COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`zakluchenie`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `zakluchenie`
--

LOCK TABLES `zakluchenie` WRITE;
/*!40000 ALTER TABLE `zakluchenie` DISABLE KEYS */;
INSERT INTO `zakluchenie` VALUES ('Брак'),('Годен');
/*!40000 ALTER TABLE `zakluchenie` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'oborot_si'
--
/*!50106 SET @save_time_zone= @@TIME_ZONE */ ;
/*!50106 DROP EVENT IF EXISTS `update_si_card_hourly` */;
DELIMITER ;;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;;
/*!50003 SET character_set_client  = utf8mb4 */ ;;
/*!50003 SET character_set_results = utf8mb4 */ ;;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;;
/*!50003 SET @saved_time_zone      = @@time_zone */ ;;
/*!50003 SET time_zone             = 'Etc/GMT-3' */ ;;
/*!50106 CREATE*/ /*!50117 DEFINER=`root`@`%`*/ /*!50106 EVENT `update_si_card_hourly` ON SCHEDULE EVERY 1 HOUR STARTS '2023-03-21 17:01:00' ON COMPLETION PRESERVE ENABLE DO CALL UPDATE_SI_CARD() */ ;;
/*!50003 SET time_zone             = @saved_time_zone */ ;;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;;
/*!50003 SET character_set_client  = @saved_cs_client */ ;;
/*!50003 SET character_set_results = @saved_cs_results */ ;;
/*!50003 SET collation_connection  = @saved_col_connection */ ;;
DELIMITER ;
/*!50106 SET TIME_ZONE= @save_time_zone */ ;

--
-- Dumping routines for database 'oborot_si'
--
/*!50003 DROP FUNCTION IF EXISTS `date_diff` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`%` FUNCTION `date_diff`(start_date DATE, finish_date DATE) RETURNS varchar(150) CHARSET utf8mb4 COLLATE utf8mb4_unicode_ci
    DETERMINISTIC
BEGIN 
	DECLARE days INT; 
	DECLARE message VARCHAR(150); 
	SET days = DATEDIFF(start_date, finish_date); 
	CASE 
		WHEN (days=365) THEN SET message = ' OK';
		WHEN (days>365) THEN SET message = ' WARNING'; 
        WHEN (days<1) THEN SET message = ' ERROR'; 
	END CASE; 
	RETURN CONCAT(days, message); 
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `GET_ALL_CHILDREN` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`%` FUNCTION `GET_ALL_CHILDREN`(start_node INT) RETURNS text CHARSET utf8mb4 COLLATE utf8mb4_unicode_ci
BEGIN
DECLARE result TEXT;
SELECT GROUP_CONCAT(`children_ids` SEPARATOR ',')  INTO result FROM (select `id_si`, @parent_values:= (SELECT GROUP_CONCAT(`id_si` SEPARATOR ',')
FROM `si_card` WHERE FIND_IN_SET(`id_si`, @parent_values) > 0 ) AS `children_ids` 
FROM `si_card` JOIN (SELECT @parent_values := start_node) AS `initialisation` 
WHERE `id_si` IN (@parent_values) ) AS `data`;
RETURN result; 
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `GET_PATH_TO_ROOT` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`%` FUNCTION `GET_PATH_TO_ROOT`(start_node INT) RETURNS text CHARSET utf8mb4 COLLATE utf8mb4_unicode_ci
BEGIN 
DECLARE path_to_root TEXT;  
DECLARE current_node TEXT; 
DECLARE EXIT HANDLER FOR NOT FOUND RETURN path_to_root; 
SET current_node = start_node; 
 SET path_to_root = start_node; 
 LOOP 
 SELECT `naimenovanie`  
 INTO current_node  
 FROM `si_card` 
 WHERE  `id_si` = current_node;  
 IF (current_node IS NOT NULL) 
 THEN 
 SET path_to_root = CONCAT(path_to_root, ',', current_node);  
 END IF; 
 END LOOP; 
 END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `COMPACT_KEYS` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`%` PROCEDURE `COMPACT_KEYS`(IN table_name VARCHAR(150), 
IN pk_name VARCHAR(150), 
OUT keys_changed INT)
BEGIN 
SET keys_changed = 0; 
SELECT 
CONCAT('Point 1. table_name = ', table_name, ', pk_name = ',  
pk_name, ', keys_changed = ', IFNULL(keys_changed, 'NULL')); 

SET @empty_key_query = 
CONCAT('SELECT MIN(`empty_key`) AS `empty_key` INTO @empty_key_value 
FROM  (SELECT `left`.`', pk_name, '` + 1 AS `empty_key` 
FROM  `', table_name, '` AS `left` 
LEFT OUTER JOIN `', table_name, '` AS `right` 
ON `left`.`', pk_name, 
'` + 1 = `right`.`', pk_name, '` 
WHERE  `right`.`', pk_name, '` IS NULL 
UNION 
SELECT 1 AS `empty_key` 
FROM  `', table_name, '` 
WHERE  NOT EXISTS(SELECT `', pk_name, '` 
FROM  `', table_name, '` 
WHERE  `', pk_name, '` = 1)) AS `prepared_data` 
WHERE `empty_key` < (SELECT MAX(`', pk_name, '`) 
FROM  `', table_name, '`)'); 
 
SET @max_key_query = 
CONCAT('SELECT MAX(`', pk_name, '`) 
INTO @max_key_value FROM `', table_name, '`'); 
SELECT CONCAT('Point 2. empty_key_query = ', @empty_key_query, 

'max_key_query = ', @max_key_query); 
PREPARE empty_key_stmt FROM @empty_key_query; 
 
 PREPARE max_key_stmt FROM @max_key_query; 
while_loop: LOOP 
EXECUTE empty_key_stmt; 
 SELECT CONCAT('Point 3. @empty_key_value = ', @empty_key_value); 
  
 IF (@empty_key_value IS NULL) 
 THEN LEAVE while_loop; 
END IF; 

EXECUTE max_key_stmt; 
SET @update_key_query = 
CONCAT('UPDATE `', table_name, '` SET `', pk_name, 
'` = @empty_key_value WHERE `', pk_name, '` = ', @max_key_value); 
 SELECT CONCAT('Point 4. @update_key_query = ', @update_key_query); 

 PREPARE update_key_stmt FROM @update_key_query; 
EXECUTE update_key_stmt; 
DEALLOCATE PREPARE update_key_stmt; 

SET keys_changed = keys_changed + 1; 
ITERATE while_loop; 

 END LOOP while_loop; 
 DEALLOCATE PREPARE max_key_stmt; 
DEALLOCATE PREPARE empty_key_stmt; 
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `UPDATE_SI_CARD` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`%` PROCEDURE `UPDATE_SI_CARD`()
BEGIN 
IF (NOT EXISTS(SELECT * 
FROM `information_schema`.`tables` 
WHERE `table_schema` = DATABASE()
AND `table_name` = 'si_card')) 
THEN 
SIGNAL SQLSTATE '45001'
SET MESSAGE_TEXT = 'The `si_card` table is missing.', 
MYSQL_ERRNO = 1001; 
END IF;
UPDATE `si_card`  
SET opisanie = 'Средство измерения (эталон)'
WHERE `etalon` = 1; 
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-04-02 20:14:49

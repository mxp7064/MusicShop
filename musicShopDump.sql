-- MySQL dump 10.13  Distrib 5.7.12, for Win64 (x86_64)
--
-- Host: localhost    Database: musicshop
-- ------------------------------------------------------
-- Server version	5.7.15-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `cartdetail`
--

DROP TABLE IF EXISTS `cartdetail`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cartdetail` (
  `cartDetailID` int(11) NOT NULL AUTO_INCREMENT,
  `productID` int(11) NOT NULL,
  `userID` int(11) NOT NULL,
  `productPrice` float DEFAULT NULL,
  PRIMARY KEY (`cartDetailID`),
  KEY `fk_ProductHasCart_Product1_idx` (`productID`),
  KEY `fk_CartDetail_User1_idx` (`userID`),
  CONSTRAINT `fk_CartDetail_Product1` FOREIGN KEY (`productID`) REFERENCES `product` (`productID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_CartDetail_User1` FOREIGN KEY (`userID`) REFERENCES `user` (`userID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=47 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cartdetail`
--

LOCK TABLES `cartdetail` WRITE;
/*!40000 ALTER TABLE `cartdetail` DISABLE KEYS */;
/*!40000 ALTER TABLE `cartdetail` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `creator`
--

DROP TABLE IF EXISTS `creator`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `creator` (
  `creatorID` int(11) NOT NULL AUTO_INCREMENT,
  `creatorName` varchar(45) DEFAULT NULL,
  `creatorDescription` varchar(500) DEFAULT NULL,
  PRIMARY KEY (`creatorID`)
) ENGINE=InnoDB AUTO_INCREMENT=3537 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `creator`
--

LOCK TABLES `creator` WRITE;
/*!40000 ALTER TABLE `creator` DISABLE KEYS */;
INSERT INTO `creator` VALUES (1,'Pevac','sdfsdf sfd s je s is lslkd sksk ei sk dkdkdkd sis kw is sksks si'),(2,'2Pevac','qwe asd zxc ewr sdf xcv rty fgh vbn tyu ghj bnm rty fgh vbn ert dfg cvb'),(3,'3cre','sdfsdfsdf');
/*!40000 ALTER TABLE `creator` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `creditcard`
--

DROP TABLE IF EXISTS `creditcard`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `creditcard` (
  `creditCardID` int(11) NOT NULL AUTO_INCREMENT,
  `creditCardNumber` int(11) DEFAULT NULL,
  `creditCardCVV` int(11) DEFAULT NULL,
  `creditBalance` float DEFAULT NULL,
  `cardProvider` varchar(45) DEFAULT NULL,
  `creditCardHolderName` varchar(45) DEFAULT NULL,
  `expirationDate` date DEFAULT NULL,
  `userID` int(11) NOT NULL,
  PRIMARY KEY (`creditCardID`),
  KEY `fk_CreditCard_User1_idx` (`userID`),
  CONSTRAINT `fk_CreditCard_User1` FOREIGN KEY (`userID`) REFERENCES `user` (`userID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `creditcard`
--

LOCK TABLES `creditcard` WRITE;
/*!40000 ALTER TABLE `creditcard` DISABLE KEYS */;
INSERT INTO `creditcard` VALUES (22,888,888,1709.53,'888','888','2017-11-01',74),(23,1,1,300,'1','1','2017-11-01',76),(24,2,2,300,'2','2','2017-11-01',76),(25,9,9,300,'9','9','2017-11-01',74);
/*!40000 ALTER TABLE `creditcard` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `genre`
--

DROP TABLE IF EXISTS `genre`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `genre` (
  `genreID` int(11) NOT NULL AUTO_INCREMENT,
  `genreName` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`genreID`)
) ENGINE=InnoDB AUTO_INCREMENT=79 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `genre`
--

LOCK TABLES `genre` WRITE;
/*!40000 ALTER TABLE `genre` DISABLE KEYS */;
INSERT INTO `genre` VALUES (1,'rock'),(2,'pop'),(3,'metal'),(4,'jazz'),(5,'edm'),(6,'dubstep');
/*!40000 ALTER TABLE `genre` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `invoice`
--

DROP TABLE IF EXISTS `invoice`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `invoice` (
  `invoiceID` int(11) NOT NULL AUTO_INCREMENT,
  `userID` int(11) NOT NULL,
  `datePurchased` datetime DEFAULT NULL,
  `total` float DEFAULT NULL,
  `discount` float DEFAULT NULL,
  `totalWithDiscount` float DEFAULT NULL,
  PRIMARY KEY (`invoiceID`),
  KEY `fk_PurchaseHistory_User1_idx` (`userID`),
  CONSTRAINT `fk_Invoice_User1` FOREIGN KEY (`userID`) REFERENCES `user` (`userID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `invoice`
--

LOCK TABLES `invoice` WRITE;
/*!40000 ALTER TABLE `invoice` DISABLE KEYS */;
INSERT INTO `invoice` VALUES (11,74,'2017-11-24 21:50:50',162.78,1.8848,159.712),(12,74,'2017-11-24 21:53:09',156.158,15.9712,131.218);
/*!40000 ALTER TABLE `invoice` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `invoicedetail`
--

DROP TABLE IF EXISTS `invoicedetail`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `invoicedetail` (
  `productID` int(11) NOT NULL,
  `invoiceID` int(11) NOT NULL,
  `productPrice` float DEFAULT NULL,
  PRIMARY KEY (`productID`,`invoiceID`),
  KEY `fk_HistoryHasProduct_Product1_idx` (`productID`),
  KEY `fk_HistoryHasProduct_PurchaseHistory1_idx` (`invoiceID`),
  CONSTRAINT `fk_InvoiceDetail_Invoice1` FOREIGN KEY (`invoiceID`) REFERENCES `invoice` (`invoiceID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_InvoiceDetail_Product1` FOREIGN KEY (`productID`) REFERENCES `product` (`productID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `invoicedetail`
--

LOCK TABLES `invoicedetail` WRITE;
/*!40000 ALTER TABLE `invoicedetail` DISABLE KEYS */;
INSERT INTO `invoicedetail` VALUES (1,12,18.848),(2,11,12.33),(2,12,12.33),(3,11,150.45),(5,12,100.42),(6,12,24.56);
/*!40000 ALTER TABLE `invoicedetail` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `product`
--

DROP TABLE IF EXISTS `product`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `product` (
  `productID` int(11) NOT NULL AUTO_INCREMENT,
  `productName` varchar(45) DEFAULT NULL,
  `productPrice` float DEFAULT NULL,
  `productCover` varchar(45) DEFAULT NULL,
  `productTypeID` int(11) NOT NULL,
  `genreID` int(11) DEFAULT NULL,
  `isDiscounted` tinyint(1) DEFAULT NULL,
  `discountRate` float DEFAULT NULL,
  `productFileName` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`productID`),
  KEY `fk_Product_ProductType1_idx` (`productTypeID`),
  KEY `fk_Product_Genre1_idx` (`genreID`),
  CONSTRAINT `fk_Product_Genre1` FOREIGN KEY (`genreID`) REFERENCES `genre` (`genreID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_Product_ProductType1` FOREIGN KEY (`productTypeID`) REFERENCES `producttype` (`productTypeID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=94 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `product`
--

LOCK TABLES `product` WRITE;
/*!40000 ALTER TABLE `product` DISABLE KEYS */;
INSERT INTO `product` VALUES (1,'Highway To Hell',23.56,'placeholder',1,1,1,20,'Vocal Exercise.wav'),(2,'Fear  The Dark',12.33,'placeholder',1,3,NULL,NULL,'Vocal Exercise.wav'),(3,'Ableton',150.45,'placeholder',2,NULL,NULL,NULL,NULL),(4,'Nexus',250.66,'placeholder',4,NULL,NULL,NULL,NULL),(5,'Vengenance',100.42,'placeholder',3,5,NULL,NULL,NULL),(6,'Anhialte',24.56,'placeholder',3,6,NULL,NULL,NULL),(7,'Destructo',12.44,'placeholder',3,6,NULL,NULL,NULL);
/*!40000 ALTER TABLE `product` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productcreator`
--

DROP TABLE IF EXISTS `productcreator`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `productcreator` (
  `creatorID` int(11) NOT NULL,
  `productID` int(11) NOT NULL,
  `creatorRole` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`creatorID`,`productID`),
  KEY `fk_ProductCreator_Creator1_idx` (`creatorID`),
  KEY `fk_ProductCreator_Product1_idx` (`productID`),
  CONSTRAINT `fk_ProductCreator_Creator1` FOREIGN KEY (`creatorID`) REFERENCES `creator` (`creatorID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_ProductCreator_Product1` FOREIGN KEY (`productID`) REFERENCES `product` (`productID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productcreator`
--

LOCK TABLES `productcreator` WRITE;
/*!40000 ALTER TABLE `productcreator` DISABLE KEYS */;
INSERT INTO `productcreator` VALUES (1,1,'singer'),(2,1,'producer'),(2,2,'qwe'),(3,1,'maker'),(3,2,'asd');
/*!40000 ALTER TABLE `productcreator` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `producttype`
--

DROP TABLE IF EXISTS `producttype`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `producttype` (
  `productTypeID` int(11) NOT NULL AUTO_INCREMENT,
  `productTypeName` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`productTypeID`)
) ENGINE=InnoDB AUTO_INCREMENT=49 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `producttype`
--

LOCK TABLES `producttype` WRITE;
/*!40000 ALTER TABLE `producttype` DISABLE KEYS */;
INSERT INTO `producttype` VALUES (1,'song'),(2,'daw'),(3,'sample pack'),(4,'plugin');
/*!40000 ALTER TABLE `producttype` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rating`
--

DROP TABLE IF EXISTS `rating`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `rating` (
  `ratingID` int(11) NOT NULL AUTO_INCREMENT,
  `ratingGrade` int(11) DEFAULT NULL,
  `comment` varchar(500) DEFAULT NULL,
  `userID` int(11) NOT NULL,
  `productID` int(11) NOT NULL,
  PRIMARY KEY (`ratingID`),
  KEY `fk_Rating_User1_idx` (`userID`),
  KEY `fk_Rating_Product1_idx` (`productID`),
  CONSTRAINT `fk_Rating_Product1` FOREIGN KEY (`productID`) REFERENCES `product` (`productID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_Rating_User1` FOREIGN KEY (`userID`) REFERENCES `user` (`userID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=82 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rating`
--

LOCK TABLES `rating` WRITE;
/*!40000 ALTER TABLE `rating` DISABLE KEYS */;
/*!40000 ALTER TABLE `rating` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `user` (
  `userID` int(11) NOT NULL AUTO_INCREMENT,
  `userName` varchar(45) DEFAULT NULL,
  `userEmail` varchar(45) DEFAULT NULL,
  `password` varchar(100) DEFAULT NULL,
  `accessLevel` varchar(45) DEFAULT NULL,
  `dateOfBirth` date DEFAULT NULL,
  `subscriptionActive` tinyint(1) DEFAULT NULL,
  `discountPoints` float DEFAULT NULL,
  PRIMARY KEY (`userID`)
) ENGINE=InnoDB AUTO_INCREMENT=77 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (74,'new','new','$MYHASH$V1$10000$fwNGoK69Wz9JTp/T71XCNFGAsG7128uGzQv8H9/Gh8kSjSBQ','admin','2016-11-20',0,13.1218),(76,'old','old','$MYHASH$V1$10000$EWaay0fgwtKDyAD4MaQHHlDJPfhbKd/SN/KlmdbalTvZO105','general','2016-11-20',0,0);
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-11-26 22:47:18

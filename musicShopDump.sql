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
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cartdetail`
--

LOCK TABLES `cartdetail` WRITE;
/*!40000 ALTER TABLE `cartdetail` DISABLE KEYS */;
INSERT INTO `cartdetail` VALUES (1,3,81,150.45),(2,4,81,250.66);
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
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `creator`
--

LOCK TABLES `creator` WRITE;
/*!40000 ALTER TABLE `creator` DISABLE KEYS */;
INSERT INTO `creator` VALUES (1,'Pevac','sdfsdf sfd s je s is lslkd sksk ei sk dkdkdkd sis kw is sksks si'),(2,'2Pevac','qwe asd zxc ewr sdf xcv rty fgh vbn tyu ghj bnm rty fgh vbn ert dfg cvb'),(3,'3cre','sdfsdfsdf'),(4,'Pevac','sdfsdf sfd s je s is lslkd sksk ei sk dkdkdkd sis kw is sksks si'),(5,'2Pevac','qwe asd zxc ewr sdf xcv rty fgh vbn tyu ghj bnm rty fgh vbn ert dfg cvb'),(6,'3cre','sdfsdfsdf'),(13,'2Pevac','qwe asd zxc ewr sdf xcv rty fgh vbn tyu ghj bnm rty fgh vbn ert dfg cvb'),(14,'3cre','sdfsdfsdf');
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
  `creditCardNumber` varchar(100) DEFAULT NULL,
  `creditCardCVV` varchar(100) DEFAULT NULL,
  `creditBalance` float DEFAULT NULL,
  `cardProvider` varchar(45) DEFAULT NULL,
  `creditCardHolderName` varchar(45) DEFAULT NULL,
  `expirationDate` date DEFAULT NULL,
  `userID` int(11) NOT NULL,
  PRIMARY KEY (`creditCardID`),
  KEY `fk_CreditCard_User1_idx` (`userID`),
  CONSTRAINT `fk_CreditCard_User1` FOREIGN KEY (`userID`) REFERENCES `user` (`userID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `creditcard`
--

LOCK TABLES `creditcard` WRITE;
/*!40000 ALTER TABLE `creditcard` DISABLE KEYS */;
INSERT INTO `creditcard` VALUES (22,'888','888',1709.53,'888','888','2017-11-01',74),(23,'1','1',300,'1','1','2017-11-01',76),(24,'2','2',300,'2','2','2017-11-01',76),(25,'9','9',300,'9','9','2017-11-01',74),(26,'888','888',1709.53,'888','888','2017-11-01',79),(27,'9','9',300,'9','9','2017-11-01',79),(28,'$MYHASH$V1$10000$oTIaWVZnJeqLJQBSVLg+blvJf+RBvsigpDMn8cJUREzRyk1q','$MYHASH$V1$10000$lQkESXd/41gEQ3aO65janvYaL3UOCih0rG6Cg1K8K4bNrZKr',600,'q','q','2017-11-01',80),(29,'$MYHASH$V1$10000$+krPr+Elrp5EdMouZ82cNfXFqU+MD/PuRD5GkgxbJc4m/qLp','$MYHASH$V1$10000$1DCHliI4swZxwew466sWVUoBRBvaaqtHIPRCAjmT48s2nSg3',319.223,'1','1','2017-11-01',81),(30,'$MYHASH$V1$10000$RdjKweDo7F8wXis836KFj7Io+hft8z/DuaXzsHDPdNeeC1uK','$MYHASH$V1$10000$HF89hxFtCutq7o2RN6ZmSLicJWhIG5CWYSZ4vckGksoi1rOg',198.89,'r','r','2017-11-01',82);
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
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `genre`
--

LOCK TABLES `genre` WRITE;
/*!40000 ALTER TABLE `genre` DISABLE KEYS */;
INSERT INTO `genre` VALUES (1,'rock'),(2,'pop'),(3,'metal'),(4,'jazz'),(5,'edm'),(6,'dubstep'),(7,'rock'),(8,'metal'),(12,'metal');
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
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `invoice`
--

LOCK TABLES `invoice` WRITE;
/*!40000 ALTER TABLE `invoice` DISABLE KEYS */;
INSERT INTO `invoice` VALUES (11,74,'2017-11-24 21:50:50',162.78,1.8848,159.712),(12,74,'2017-11-24 21:53:09',156.158,15.9712,131.218),(13,82,'2017-11-28 21:47:14',401.11,0,401.11);
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
INSERT INTO `invoicedetail` VALUES (3,11,150.45),(3,13,150.45),(4,13,250.66),(5,12,100.42),(6,12,24.56);
/*!40000 ALTER TABLE `invoicedetail` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `log`
--

DROP TABLE IF EXISTS `log`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `log` (
  `logID` int(11) NOT NULL AUTO_INCREMENT,
  `userID` int(11) DEFAULT NULL,
  `timeStamp` datetime DEFAULT NULL,
  `logMessage` varchar(2000) DEFAULT NULL,
  PRIMARY KEY (`logID`)
) ENGINE=InnoDB AUTO_INCREMENT=3044 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `log`
--

LOCK TABLES `log` WRITE;
/*!40000 ALTER TABLE `log` DISABLE KEYS */;
INSERT INTO `log` VALUES (2763,80,'2017-11-29 00:38:06','Closed connection at 11/29/2017 12:38:06 AM +01:00\r\n'),(2764,80,'2017-11-29 00:38:16','Opened connection at 11/29/2017 12:38:16 AM +01:00\r\n'),(2765,80,'2017-11-29 00:38:16','Started transaction at 11/29/2017 12:38:16 AM +01:00\r\n'),(2766,80,'2017-11-29 00:38:17','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2509\'\r\n'),(2767,80,'2017-11-29 00:38:17','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2510\'\r\n'),(2768,80,'2017-11-29 00:38:17','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2511\'\r\n'),(2769,80,'2017-11-29 00:38:17','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2512\'\r\n'),(2770,80,'2017-11-29 00:38:17','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2513\'\r\n'),(2771,80,'2017-11-29 00:38:17','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2514\'\r\n'),(2772,80,'2017-11-29 00:38:17','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2515\'\r\n'),(2773,80,'2017-11-29 00:38:17','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2516\'\r\n'),(2774,80,'2017-11-29 00:38:17','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2517\'\r\n'),(2775,80,'2017-11-29 00:38:17','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2518\'\r\n'),(2776,80,'2017-11-29 00:38:17','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2519\'\r\n'),(2777,80,'2017-11-29 00:38:17','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2520\'\r\n'),(2778,80,'2017-11-29 00:38:17','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2521\'\r\n'),(2779,80,'2017-11-29 00:38:17','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2522\'\r\n'),(2780,80,'2017-11-29 00:38:17','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2523\'\r\n'),(2781,80,'2017-11-29 00:38:17','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2524\'\r\n'),(2782,80,'2017-11-29 00:38:17','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2525\'\r\n'),(2783,80,'2017-11-29 00:38:17','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2526\'\r\n'),(2784,80,'2017-11-29 00:38:17','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2527\'\r\n'),(2785,80,'2017-11-29 00:38:17','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2528\'\r\n'),(2786,80,'2017-11-29 00:38:17','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2529\'\r\n'),(2787,80,'2017-11-29 00:38:17','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2530\'\r\n'),(2788,80,'2017-11-29 00:38:18','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2531\'\r\n'),(2789,80,'2017-11-29 00:38:18','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2532\'\r\n'),(2790,80,'2017-11-29 00:38:18','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2533\'\r\n'),(2791,80,'2017-11-29 00:38:18','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2534\'\r\n'),(2792,80,'2017-11-29 00:38:18','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2535\'\r\n'),(2793,80,'2017-11-29 00:38:18','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2536\'\r\n'),(2794,80,'2017-11-29 00:38:18','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2537\'\r\n'),(2795,80,'2017-11-29 00:38:18','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2538\'\r\n'),(2796,80,'2017-11-29 00:38:18','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2539\'\r\n'),(2797,80,'2017-11-29 00:38:18','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2540\'\r\n'),(2798,80,'2017-11-29 00:38:18','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2541\'\r\n'),(2799,80,'2017-11-29 00:38:18','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2542\'\r\n'),(2800,80,'2017-11-29 00:38:18','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2543\'\r\n'),(2801,80,'2017-11-29 00:38:18','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2544\'\r\n'),(2802,80,'2017-11-29 00:38:18','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2545\'\r\n'),(2803,80,'2017-11-29 00:38:18','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2546\'\r\n'),(2804,80,'2017-11-29 00:38:18','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2547\'\r\n'),(2805,80,'2017-11-29 00:38:18','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2548\'\r\n'),(2806,80,'2017-11-29 00:38:18','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2549\'\r\n'),(2807,80,'2017-11-29 00:38:18','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2550\'\r\n'),(2808,80,'2017-11-29 00:38:18','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2551\'\r\n'),(2809,80,'2017-11-29 00:38:19','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2552\'\r\n'),(2810,80,'2017-11-29 00:38:19','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2553\'\r\n'),(2811,80,'2017-11-29 00:38:19','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2554\'\r\n'),(2812,80,'2017-11-29 00:38:19','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2555\'\r\n'),(2813,80,'2017-11-29 00:38:19','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2556\'\r\n'),(2814,80,'2017-11-29 00:38:19','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2557\'\r\n'),(2815,80,'2017-11-29 00:38:19','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2558\'\r\n'),(2816,80,'2017-11-29 00:38:19','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2559\'\r\n'),(2817,80,'2017-11-29 00:38:19','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2560\'\r\n'),(2818,80,'2017-11-29 00:38:19','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2561\'\r\n'),(2819,80,'2017-11-29 00:38:19','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2562\'\r\n'),(2820,80,'2017-11-29 00:38:19','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2563\'\r\n'),(2821,80,'2017-11-29 00:38:19','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2564\'\r\n'),(2822,80,'2017-11-29 00:38:19','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2565\'\r\n'),(2823,80,'2017-11-29 00:38:19','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2566\'\r\n'),(2824,80,'2017-11-29 00:38:19','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2567\'\r\n'),(2825,80,'2017-11-29 00:38:19','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2568\'\r\n'),(2826,80,'2017-11-29 00:38:19','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2569\'\r\n'),(2827,80,'2017-11-29 00:38:19','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2570\'\r\n'),(2828,80,'2017-11-29 00:38:19','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2571\'\r\n'),(2829,80,'2017-11-29 00:38:19','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2572\'\r\n'),(2830,80,'2017-11-29 00:38:19','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2573\'\r\n'),(2831,80,'2017-11-29 00:38:19','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2574\'\r\n'),(2832,80,'2017-11-29 00:38:19','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2575\'\r\n'),(2833,80,'2017-11-29 00:38:20','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2576\'\r\n'),(2834,80,'2017-11-29 00:38:20','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2577\'\r\n'),(2835,80,'2017-11-29 00:38:20','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2578\'\r\n'),(2836,80,'2017-11-29 00:38:20','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2579\'\r\n'),(2837,80,'2017-11-29 00:38:20','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2580\'\r\n'),(2838,80,'2017-11-29 00:38:20','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2581\'\r\n'),(2839,80,'2017-11-29 00:38:20','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2582\'\r\n'),(2840,80,'2017-11-29 00:38:20','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2583\'\r\n'),(2841,80,'2017-11-29 00:38:20','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2584\'\r\n'),(2842,80,'2017-11-29 00:38:20','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2585\'\r\n'),(2843,80,'2017-11-29 00:38:20','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2586\'\r\n'),(2844,80,'2017-11-29 00:38:20','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2587\'\r\n'),(2845,80,'2017-11-29 00:38:20','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2588\'\r\n'),(2846,80,'2017-11-29 00:38:20','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2589\'\r\n'),(2847,80,'2017-11-29 00:38:20','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2590\'\r\n'),(2848,80,'2017-11-29 00:38:20','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2591\'\r\n'),(2849,80,'2017-11-29 00:38:20','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2592\'\r\n'),(2850,80,'2017-11-29 00:38:20','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2593\'\r\n'),(2851,80,'2017-11-29 00:38:20','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2594\'\r\n'),(2852,80,'2017-11-29 00:38:20','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2595\'\r\n'),(2853,80,'2017-11-29 00:38:20','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2596\'\r\n'),(2854,80,'2017-11-29 00:38:20','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2597\'\r\n'),(2855,80,'2017-11-29 00:38:21','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2598\'\r\n'),(2856,80,'2017-11-29 00:38:21','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2599\'\r\n'),(2857,80,'2017-11-29 00:38:21','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2600\'\r\n'),(2858,80,'2017-11-29 00:38:21','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2601\'\r\n'),(2859,80,'2017-11-29 00:38:21','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2602\'\r\n'),(2860,80,'2017-11-29 00:38:21','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2603\'\r\n'),(2861,80,'2017-11-29 00:38:21','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2604\'\r\n'),(2862,80,'2017-11-29 00:38:21','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2605\'\r\n'),(2863,80,'2017-11-29 00:38:21','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2606\'\r\n'),(2864,80,'2017-11-29 00:38:21','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2607\'\r\n'),(2865,80,'2017-11-29 00:38:21','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2608\'\r\n'),(2866,80,'2017-11-29 00:38:21','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2609\'\r\n'),(2867,80,'2017-11-29 00:38:21','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2610\'\r\n'),(2868,80,'2017-11-29 00:38:21','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2611\'\r\n'),(2869,80,'2017-11-29 00:38:21','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2612\'\r\n'),(2870,80,'2017-11-29 00:38:21','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2613\'\r\n'),(2871,80,'2017-11-29 00:38:21','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2614\'\r\n'),(2872,80,'2017-11-29 00:38:21','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2615\'\r\n'),(2873,80,'2017-11-29 00:38:21','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2616\'\r\n'),(2874,80,'2017-11-29 00:38:21','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2617\'\r\n'),(2875,80,'2017-11-29 00:38:21','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2618\'\r\n'),(2876,80,'2017-11-29 00:38:21','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2619\'\r\n'),(2877,80,'2017-11-29 00:38:21','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2620\'\r\n'),(2878,80,'2017-11-29 00:38:22','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2621\'\r\n'),(2879,80,'2017-11-29 00:38:22','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2622\'\r\n'),(2880,80,'2017-11-29 00:38:22','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2623\'\r\n'),(2881,80,'2017-11-29 00:38:22','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2624\'\r\n'),(2882,80,'2017-11-29 00:38:22','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2625\'\r\n'),(2883,80,'2017-11-29 00:38:22','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2626\'\r\n'),(2884,80,'2017-11-29 00:38:22','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2627\'\r\n'),(2885,80,'2017-11-29 00:38:22','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2628\'\r\n'),(2886,80,'2017-11-29 00:38:22','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2629\'\r\n'),(2887,80,'2017-11-29 00:38:22','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2630\'\r\n'),(2888,80,'2017-11-29 00:38:22','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2631\'\r\n'),(2889,80,'2017-11-29 00:38:22','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2632\'\r\n'),(2890,80,'2017-11-29 00:38:22','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2633\'\r\n'),(2891,80,'2017-11-29 00:38:22','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2634\'\r\n'),(2892,80,'2017-11-29 00:38:22','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2635\'\r\n'),(2893,80,'2017-11-29 00:38:22','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2636\'\r\n'),(2894,80,'2017-11-29 00:38:22','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2637\'\r\n'),(2895,80,'2017-11-29 00:38:22','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2638\'\r\n'),(2896,80,'2017-11-29 00:38:22','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2639\'\r\n'),(2897,80,'2017-11-29 00:38:22','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2640\'\r\n'),(2898,80,'2017-11-29 00:38:22','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2641\'\r\n'),(2899,80,'2017-11-29 00:38:22','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2642\'\r\n'),(2900,80,'2017-11-29 00:38:22','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2643\'\r\n'),(2901,80,'2017-11-29 00:38:22','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2644\'\r\n'),(2902,80,'2017-11-29 00:38:23','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2645\'\r\n'),(2903,80,'2017-11-29 00:38:23','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2646\'\r\n'),(2904,80,'2017-11-29 00:38:23','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2647\'\r\n'),(2905,80,'2017-11-29 00:38:23','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2648\'\r\n'),(2906,80,'2017-11-29 00:38:23','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2649\'\r\n'),(2907,80,'2017-11-29 00:38:23','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2650\'\r\n'),(2908,80,'2017-11-29 00:38:23','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2651\'\r\n'),(2909,80,'2017-11-29 00:38:23','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2652\'\r\n'),(2910,80,'2017-11-29 00:38:23','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2653\'\r\n'),(2911,80,'2017-11-29 00:38:23','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2654\'\r\n'),(2912,80,'2017-11-29 00:38:23','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2655\'\r\n'),(2913,80,'2017-11-29 00:38:23','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2656\'\r\n'),(2914,80,'2017-11-29 00:38:23','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2657\'\r\n'),(2915,80,'2017-11-29 00:38:23','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2658\'\r\n'),(2916,80,'2017-11-29 00:38:23','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2659\'\r\n'),(2917,80,'2017-11-29 00:38:23','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2660\'\r\n'),(2918,80,'2017-11-29 00:38:23','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2661\'\r\n'),(2919,80,'2017-11-29 00:38:23','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2662\'\r\n'),(2920,80,'2017-11-29 00:38:23','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2663\'\r\n'),(2921,80,'2017-11-29 00:38:23','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2664\'\r\n'),(2922,80,'2017-11-29 00:38:23','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2665\'\r\n'),(2923,80,'2017-11-29 00:38:23','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2666\'\r\n'),(2924,80,'2017-11-29 00:38:24','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2667\'\r\n'),(2925,80,'2017-11-29 00:38:24','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2668\'\r\n'),(2926,80,'2017-11-29 00:38:24','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2669\'\r\n'),(2927,80,'2017-11-29 00:38:24','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2670\'\r\n'),(2928,80,'2017-11-29 00:38:24','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2671\'\r\n'),(2929,80,'2017-11-29 00:38:24','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2672\'\r\n'),(2930,80,'2017-11-29 00:38:24','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2673\'\r\n'),(2931,80,'2017-11-29 00:38:24','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2674\'\r\n'),(2932,80,'2017-11-29 00:38:24','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2675\'\r\n'),(2933,80,'2017-11-29 00:38:24','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2676\'\r\n'),(2934,80,'2017-11-29 00:38:24','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2677\'\r\n'),(2935,80,'2017-11-29 00:38:24','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2678\'\r\n'),(2936,80,'2017-11-29 00:38:24','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2679\'\r\n'),(2937,80,'2017-11-29 00:38:25','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2680\'\r\n'),(2938,80,'2017-11-29 00:38:25','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2681\'\r\n'),(2939,80,'2017-11-29 00:38:25','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2682\'\r\n'),(2940,80,'2017-11-29 00:38:25','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2683\'\r\n'),(2941,80,'2017-11-29 00:38:25','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2684\'\r\n'),(2942,80,'2017-11-29 00:38:25','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2685\'\r\n'),(2943,80,'2017-11-29 00:38:25','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2686\'\r\n'),(2944,80,'2017-11-29 00:38:25','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2687\'\r\n'),(2945,80,'2017-11-29 00:38:25','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2688\'\r\n'),(2946,80,'2017-11-29 00:38:25','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2689\'\r\n'),(2947,80,'2017-11-29 00:38:25','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2690\'\r\n'),(2948,80,'2017-11-29 00:38:25','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2691\'\r\n'),(2949,80,'2017-11-29 00:38:25','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2692\'\r\n'),(2950,80,'2017-11-29 00:38:25','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2693\'\r\n'),(2951,80,'2017-11-29 00:38:25','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2694\'\r\n'),(2952,80,'2017-11-29 00:38:25','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2695\'\r\n'),(2953,80,'2017-11-29 00:38:25','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2696\'\r\n'),(2954,80,'2017-11-29 00:38:25','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2697\'\r\n'),(2955,80,'2017-11-29 00:38:25','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2698\'\r\n'),(2956,80,'2017-11-29 00:38:26','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2699\'\r\n'),(2957,80,'2017-11-29 00:38:26','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2700\'\r\n'),(2958,80,'2017-11-29 00:38:26','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2701\'\r\n'),(2959,80,'2017-11-29 00:38:26','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2702\'\r\n'),(2960,80,'2017-11-29 00:38:26','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2703\'\r\n'),(2961,80,'2017-11-29 00:38:26','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2704\'\r\n'),(2962,80,'2017-11-29 00:38:26','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2705\'\r\n'),(2963,80,'2017-11-29 00:38:26','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2706\'\r\n'),(2964,80,'2017-11-29 00:38:26','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2707\'\r\n'),(2965,80,'2017-11-29 00:38:26','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2708\'\r\n'),(2966,80,'2017-11-29 00:38:26','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2709\'\r\n'),(2967,80,'2017-11-29 00:38:26','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2710\'\r\n'),(2968,80,'2017-11-29 00:38:26','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2711\'\r\n'),(2969,80,'2017-11-29 00:38:26','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2712\'\r\n'),(2970,80,'2017-11-29 00:38:26','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2713\'\r\n'),(2971,80,'2017-11-29 00:38:26','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2714\'\r\n'),(2972,80,'2017-11-29 00:38:26','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2715\'\r\n'),(2973,80,'2017-11-29 00:38:26','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2716\'\r\n'),(2974,80,'2017-11-29 00:38:26','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2717\'\r\n'),(2975,80,'2017-11-29 00:38:26','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2718\'\r\n'),(2976,80,'2017-11-29 00:38:26','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2719\'\r\n'),(2977,80,'2017-11-29 00:38:27','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2720\'\r\n'),(2978,80,'2017-11-29 00:38:27','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2721\'\r\n'),(2979,80,'2017-11-29 00:38:27','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2722\'\r\n'),(2980,80,'2017-11-29 00:38:27','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2723\'\r\n'),(2981,80,'2017-11-29 00:38:27','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2724\'\r\n'),(2982,80,'2017-11-29 00:38:27','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2725\'\r\n'),(2983,80,'2017-11-29 00:38:27','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2726\'\r\n'),(2984,80,'2017-11-29 00:38:27','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2727\'\r\n'),(2985,80,'2017-11-29 00:38:27','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2728\'\r\n'),(2986,80,'2017-11-29 00:38:27','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2729\'\r\n'),(2987,80,'2017-11-29 00:38:27','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2730\'\r\n'),(2988,80,'2017-11-29 00:38:27','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2731\'\r\n'),(2989,80,'2017-11-29 00:38:27','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2732\'\r\n'),(2990,80,'2017-11-29 00:38:27','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2733\'\r\n'),(2991,80,'2017-11-29 00:38:27','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2734\'\r\n'),(2992,80,'2017-11-29 00:38:27','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2735\'\r\n'),(2993,80,'2017-11-29 00:38:27','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2736\'\r\n'),(2994,80,'2017-11-29 00:38:27','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2737\'\r\n'),(2995,80,'2017-11-29 00:38:27','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2738\'\r\n'),(2996,80,'2017-11-29 00:38:28','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2739\'\r\n'),(2997,80,'2017-11-29 00:38:28','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2740\'\r\n'),(2998,80,'2017-11-29 00:38:28','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2741\'\r\n'),(2999,80,'2017-11-29 00:38:28','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2742\'\r\n'),(3000,80,'2017-11-29 00:38:28','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2743\'\r\n'),(3001,80,'2017-11-29 00:38:28','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2744\'\r\n'),(3002,80,'2017-11-29 00:38:28','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2745\'\r\n'),(3003,80,'2017-11-29 00:38:28','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2746\'\r\n'),(3004,80,'2017-11-29 00:38:28','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2747\'\r\n'),(3005,80,'2017-11-29 00:38:28','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2748\'\r\n'),(3006,80,'2017-11-29 00:38:28','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2749\'\r\n'),(3007,80,'2017-11-29 00:38:28','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2750\'\r\n'),(3008,80,'2017-11-29 00:38:28','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2751\'\r\n'),(3009,80,'2017-11-29 00:38:28','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2752\'\r\n'),(3010,80,'2017-11-29 00:38:28','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2753\'\r\n'),(3011,80,'2017-11-29 00:38:28','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2754\'\r\n'),(3012,80,'2017-11-29 00:38:28','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2755\'\r\n'),(3013,80,'2017-11-29 00:38:28','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2756\'\r\n'),(3014,80,'2017-11-29 00:38:28','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2757\'\r\n'),(3015,80,'2017-11-29 00:38:28','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2758\'\r\n'),(3016,80,'2017-11-29 00:38:28','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2759\'\r\n'),(3017,80,'2017-11-29 00:38:28','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2760\'\r\n'),(3018,80,'2017-11-29 00:38:28','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2761\'\r\n'),(3019,80,'2017-11-29 00:38:29','Context \'musicShopEntities\' is executing command \'DELETE FROM `log` WHERE `logID` = 2762\'\r\n'),(3020,80,'2017-11-29 00:38:29','Committed transaction at 11/29/2017 12:38:28 AM +01:00\r\n'),(3021,80,'2017-11-29 00:38:29','Closed connection at 11/29/2017 12:38:28 AM +01:00\r\n'),(3022,80,'2017-11-29 00:38:29','Disposed transaction at 11/29/2017 12:38:28 AM +01:00\r\n'),(3023,80,'2017-11-29 00:38:38','Opened connection at 11/29/2017 12:38:37 AM +01:00\r\n'),(3024,80,'2017-11-29 00:38:38','Started transaction at 11/29/2017 12:38:37 AM +01:00\r\n'),(3025,80,'2017-11-29 00:38:38','Context \'musicShopEntities\' is executing command \'SET SESSION sql_mode=\'ANSI\';INSERT INTO `product`(`productName`, `productPrice`, `productCover`, `productTypeID`, `genreID`, `isDiscounted`, `discountRate`, `productFileName`) VALUES (NULL, 23.77, NULL, 2, NULL, NULL, NULL, NULL);SELECT`productID`FROM `product` WHERE  row_count() > 0 AND `productID`=last_insert_id()\'\r\n'),(3026,80,'2017-11-29 00:38:38','Committed transaction at 11/29/2017 12:38:37 AM +01:00\r\n'),(3027,80,'2017-11-29 00:38:38','Closed connection at 11/29/2017 12:38:38 AM +01:00\r\n'),(3028,80,'2017-11-29 00:38:38','Disposed transaction at 11/29/2017 12:38:38 AM +01:00\r\n'),(3029,80,'2017-11-29 00:38:40','Opened connection at 11/29/2017 12:38:40 AM +01:00\r\n'),(3030,80,'2017-11-29 00:38:40','Context \'musicShopEntities\' is executing command \'SELECT`Extent1`.`logID`, `Extent1`.`userID`, `Extent1`.`timeStamp`, `Extent1`.`logMessage`FROM `log` AS `Extent1`\'\r\n'),(3031,80,'2017-11-29 00:38:40','Closed connection at 11/29/2017 12:38:40 AM +01:00\r\n'),(3032,80,'2017-11-29 00:39:06','Opened connection at 11/29/2017 12:39:05 AM +01:00\r\n'),(3033,80,'2017-11-29 00:39:06','Context \'musicShopEntities\' is executing command \'SELECT`Extent1`.`logID`, `Extent1`.`userID`, `Extent1`.`timeStamp`, `Extent1`.`logMessage`FROM `log` AS `Extent1`\'\r\n'),(3034,80,'2017-11-29 00:39:06','Closed connection at 11/29/2017 12:39:06 AM +01:00\r\n'),(3035,80,'2017-11-29 00:39:19','Opened connection at 11/29/2017 12:39:19 AM +01:00\r\n'),(3036,80,'2017-11-29 00:39:19','Started transaction at 11/29/2017 12:39:19 AM +01:00\r\n'),(3037,80,'2017-11-29 00:39:20','Context \'musicShopEntities\' is executing command \'SET SESSION sql_mode=\'ANSI\';INSERT INTO `product`(`productName`, `productPrice`, `productCover`, `productTypeID`, `genreID`, `isDiscounted`, `discountRate`, `productFileName`) VALUES (NULL, 34.67, NULL, 2, NULL, NULL, NULL, NULL);SELECT`productID`FROM `product` WHERE  row_count() > 0 AND `productID`=last_insert_id()\'\r\n'),(3038,80,'2017-11-29 00:39:20','Committed transaction at 11/29/2017 12:39:19 AM +01:00\r\n'),(3039,80,'2017-11-29 00:39:20','Closed connection at 11/29/2017 12:39:19 AM +01:00\r\n'),(3040,80,'2017-11-29 00:39:20','Disposed transaction at 11/29/2017 12:39:19 AM +01:00\r\n'),(3041,80,'2017-11-29 00:39:23','Opened connection at 11/29/2017 12:39:22 AM +01:00\r\n'),(3042,80,'2017-11-29 00:39:23','Context \'musicShopEntities\' is executing command \'SELECT`Extent1`.`logID`, `Extent1`.`userID`, `Extent1`.`timeStamp`, `Extent1`.`logMessage`FROM `log` AS `Extent1`\'\r\n'),(3043,80,'2017-11-29 00:39:23','Closed connection at 11/29/2017 12:39:22 AM +01:00\r\n');
/*!40000 ALTER TABLE `log` ENABLE KEYS */;
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
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `product`
--

LOCK TABLES `product` WRITE;
/*!40000 ALTER TABLE `product` DISABLE KEYS */;
INSERT INTO `product` VALUES (3,'Ableton',150.45,'placeholder',2,NULL,NULL,NULL,NULL),(4,'Nexus',250.66,'placeholder',4,NULL,NULL,NULL,NULL),(5,'Vengenance',100.42,'placeholder',3,5,NULL,NULL,NULL),(6,'Anhialte',24.56,'placeholder',3,6,NULL,NULL,NULL),(7,'Destructo',12.44,'placeholder',3,6,NULL,NULL,NULL),(14,'Fear  The Dark',12.33,'placeholder',9,12,NULL,NULL,'Vocal Exercise.wav'),(15,NULL,34.67,NULL,1,1,NULL,NULL,NULL),(16,NULL,34.56,NULL,1,NULL,NULL,NULL,NULL),(17,NULL,23.77,NULL,2,NULL,NULL,NULL,NULL),(18,NULL,34.67,NULL,2,NULL,NULL,NULL,NULL);
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
INSERT INTO `productcreator` VALUES (13,14,'qwe'),(14,14,'asd');
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
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `producttype`
--

LOCK TABLES `producttype` WRITE;
/*!40000 ALTER TABLE `producttype` DISABLE KEYS */;
INSERT INTO `producttype` VALUES (1,'song'),(2,'daw'),(3,'sample pack'),(4,'plugin'),(9,'song');
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
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rating`
--

LOCK TABLES `rating` WRITE;
/*!40000 ALTER TABLE `rating` DISABLE KEYS */;
INSERT INTO `rating` VALUES (4,5,'qwe',80,14);
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
  `discountPoints` float DEFAULT NULL,
  PRIMARY KEY (`userID`)
) ENGINE=InnoDB AUTO_INCREMENT=83 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (74,'new','new','$MYHASH$V1$10000$fwNGoK69Wz9JTp/T71XCNFGAsG7128uGzQv8H9/Gh8kSjSBQ','admin','2016-11-20',13.1218),(76,'old','old','$MYHASH$V1$10000$EWaay0fgwtKDyAD4MaQHHlDJPfhbKd/SN/KlmdbalTvZO105','general','2016-11-20',0),(77,'a','a','$MYHASH$V1$10000$ZgeflzSFE4U1JipM1v8WrcX/1WDrtZ+uApexeoZ0K1Y81gII','general','2016-11-20',0),(78,'','',NULL,'general','2016-11-20',0),(79,'new','new','$MYHASH$V1$10000$fwNGoK69Wz9JTp/T71XCNFGAsG7128uGzQv8H9/Gh8kSjSBQ','admin','2016-11-20',13.1218),(80,'new','new','$MYHASH$V1$10000$fwNGoK69Wz9JTp/T71XCNFGAsG7128uGzQv8H9/Gh8kSjSBQ','admin','2016-11-20',13.1218),(81,'Marko Pancirov','mxp7064@g.rit.edu','$MYHASH$V1$10000$9Ryvh9OTJMe2LvxZb5sQzamZbDFqpFoZMEqddfWZCZemBq9z','general','2016-11-20',68.1887),(82,'r','mxp7064@g.rit.edu','$MYHASH$V1$10000$/MDpQOIBbPUdRiuNhpdLa07BWtl3zK2KUReZrvAF4v3gUJsc','general','2016-11-20',40.111);
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

-- Dump completed on 2017-11-29 23:06:23

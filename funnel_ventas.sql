CREATE DATABASE  IF NOT EXISTS `funnel_ventas2` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `funnel_ventas2`;
-- MySQL dump 10.13  Distrib 8.0.27, for Win64 (x86_64)
--
-- Host: localhost    Database: funnel_ventas2
-- ------------------------------------------------------
-- Server version	8.0.27

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
-- Table structure for table `prox_gestion`
--

DROP TABLE IF EXISTS `prox_gestion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `prox_gestion` (
  `id_tipo_gestion` int NOT NULL AUTO_INCREMENT,
  `nombre_tipo_gestion` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_tipo_gestion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prox_gestion`
--

LOCK TABLES `prox_gestion` WRITE;
/*!40000 ALTER TABLE `prox_gestion` DISABLE KEYS */;
/*!40000 ALTER TABLE `prox_gestion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipo_ancho`
--

DROP TABLE IF EXISTS `tipo_ancho`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tipo_ancho` (
  `id_tipo_ancho` int NOT NULL AUTO_INCREMENT,
  `nombre_tipo_ancho` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_tipo_ancho`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo_ancho`
--

LOCK TABLES `tipo_ancho` WRITE;
/*!40000 ALTER TABLE `tipo_ancho` DISABLE KEYS */;
/*!40000 ALTER TABLE `tipo_ancho` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipo_clase`
--

DROP TABLE IF EXISTS `tipo_clase`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tipo_clase` (
  `id_tipo_clase` int NOT NULL AUTO_INCREMENT,
  `nombre_tipo_clase` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_tipo_clase`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo_clase`
--

LOCK TABLES `tipo_clase` WRITE;
/*!40000 ALTER TABLE `tipo_clase` DISABLE KEYS */;
/*!40000 ALTER TABLE `tipo_clase` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipo_consultoria`
--

DROP TABLE IF EXISTS `tipo_consultoria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tipo_consultoria` (
  `id_tipo_consultoria` int NOT NULL AUTO_INCREMENT,
  `nombre_tipo_consultoria` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_tipo_consultoria`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo_consultoria`
--

LOCK TABLES `tipo_consultoria` WRITE;
/*!40000 ALTER TABLE `tipo_consultoria` DISABLE KEYS */;
/*!40000 ALTER TABLE `tipo_consultoria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipo_consultoria2`
--

DROP TABLE IF EXISTS `tipo_consultoria2`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tipo_consultoria2` (
  `id_tipo_consultoria2` int NOT NULL AUTO_INCREMENT,
  `nombre_tipo_consultoria2` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_tipo_consultoria2`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo_consultoria2`
--

LOCK TABLES `tipo_consultoria2` WRITE;
/*!40000 ALTER TABLE `tipo_consultoria2` DISABLE KEYS */;
/*!40000 ALTER TABLE `tipo_consultoria2` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipo_enlace`
--

DROP TABLE IF EXISTS `tipo_enlace`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tipo_enlace` (
  `id_tipo_enlace` int NOT NULL AUTO_INCREMENT,
  `nombre_tipo_enlace` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_tipo_enlace`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo_enlace`
--

LOCK TABLES `tipo_enlace` WRITE;
/*!40000 ALTER TABLE `tipo_enlace` DISABLE KEYS */;
/*!40000 ALTER TABLE `tipo_enlace` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipo_equipo`
--

DROP TABLE IF EXISTS `tipo_equipo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tipo_equipo` (
  `id_tipo_equipo` int NOT NULL AUTO_INCREMENT,
  `nombre_tipo_equipo` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_tipo_equipo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo_equipo`
--

LOCK TABLES `tipo_equipo` WRITE;
/*!40000 ALTER TABLE `tipo_equipo` DISABLE KEYS */;
/*!40000 ALTER TABLE `tipo_equipo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipo_estado`
--

DROP TABLE IF EXISTS `tipo_estado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tipo_estado` (
  `id_tipo_estado` int NOT NULL AUTO_INCREMENT,
  `nombre_tipo_estado` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_tipo_estado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo_estado`
--

LOCK TABLES `tipo_estado` WRITE;
/*!40000 ALTER TABLE `tipo_estado` DISABLE KEYS */;
/*!40000 ALTER TABLE `tipo_estado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipo_gestion`
--

DROP TABLE IF EXISTS `tipo_gestion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tipo_gestion` (
  `id_tipo_gestion` int NOT NULL AUTO_INCREMENT,
  `nombre_tipo_gestion` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_tipo_gestion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo_gestion`
--

LOCK TABLES `tipo_gestion` WRITE;
/*!40000 ALTER TABLE `tipo_gestion` DISABLE KEYS */;
/*!40000 ALTER TABLE `tipo_gestion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipo_marca`
--

DROP TABLE IF EXISTS `tipo_marca`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tipo_marca` (
  `id_tipo_marca` int NOT NULL AUTO_INCREMENT,
  `nombre_tipo_marca` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_tipo_marca`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo_marca`
--

LOCK TABLES `tipo_marca` WRITE;
/*!40000 ALTER TABLE `tipo_marca` DISABLE KEYS */;
/*!40000 ALTER TABLE `tipo_marca` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipo_usuario`
--

DROP TABLE IF EXISTS `tipo_usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tipo_usuario` (
  `id_tipo_usuario` int NOT NULL AUTO_INCREMENT,
  `nombre_tipo_usuario` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_tipo_usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo_usuario`
--

LOCK TABLES `tipo_usuario` WRITE;
/*!40000 ALTER TABLE `tipo_usuario` DISABLE KEYS */;
INSERT INTO `tipo_usuario` VALUES (1,'admin'),(2,'usuario');
/*!40000 ALTER TABLE `tipo_usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuario` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) DEFAULT NULL,
  `password` varchar(10) DEFAULT NULL,
  `usuario` varchar(20) DEFAULT NULL,
  `id_tipo` int DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (1,'admin','admin','admin',1),(4,'vende','1234','vende',2),(5,'admin2','admin','admin2',1);
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ventas`
--

DROP TABLE IF EXISTS `ventas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ventas` (
  `id_venta` int NOT NULL AUTO_INCREMENT,
  `nombre_cliente` varchar(100) DEFAULT NULL,
  `Ejecutivo_Cuentas` varchar(100) DEFAULT NULL,
  `tipo_gestion` int DEFAULT NULL,
  `tipo_estado` int DEFAULT NULL,
  `prox_Gestion` int DEFAULT NULL,
  `fecha_inicial` varchar(100) DEFAULT NULL,
  `cantidad_equipo` int DEFAULT NULL,
  `tipo_equipo` int DEFAULT NULL,
  `marca_equipo` int DEFAULT NULL,
  `detalle_equipo` varchar(10) DEFAULT NULL,
  `monto_equipo` int DEFAULT NULL,
  `cantidad_enlace` int DEFAULT NULL,
  `tipo_enlace` int DEFAULT NULL,
  `tipo_ancho` int DEFAULT NULL,
  `detalle_enlace` varchar(10) DEFAULT NULL,
  `monto_enlace` int DEFAULT NULL,
  `cantidad_consultoria` int DEFAULT NULL,
  `tipo_consultoria` int DEFAULT NULL,
  `tipo_consultoria2` int DEFAULT NULL,
  `detalle_consultoria` varchar(10) DEFAULT NULL,
  `monto_consultoria` int DEFAULT NULL,
  `total` int DEFAULT NULL,
  PRIMARY KEY (`id_venta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ventas`
--

LOCK TABLES `ventas` WRITE;
/*!40000 ALTER TABLE `ventas` DISABLE KEYS */;
/*!40000 ALTER TABLE `ventas` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-12-02 19:49:45

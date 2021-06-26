-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 26-06-2021 a las 05:45:29
-- Versión del servidor: 10.4.18-MariaDB
-- Versión de PHP: 8.0.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `bd_unimex_izcalli`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_alumnos_izcalli`
--

CREATE TABLE `tb_alumnos_izcalli` (
  `AL_ID` int(10) NOT NULL,
  `AL_NOMBRE` varchar(100) NOT NULL,
  `AL_CURP` varchar(50) NOT NULL,
  `AL_CARRERA` varchar(150) NOT NULL,
  `AL_PLANTEL` varchar(100) NOT NULL,
  `AL_ESTATUS` varchar(100) NOT NULL,
  `AL_TELEFONO` varchar(100) NOT NULL,
  `AL_EMAIL` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_alumnos_izcalli`
--

INSERT INTO `tb_alumnos_izcalli` (`AL_ID`, `AL_NOMBRE`, `AL_CURP`, `AL_CARRERA`, `AL_PLANTEL`, `AL_ESTATUS`, `AL_TELEFONO`, `AL_EMAIL`) VALUES
(1, 'JIMENA VALADEZ CRISANTO', 'VACJ040516MDFDFR05', 'INGENIERIA EN SISTEMAS COMPUTACIONALES', 'IZCALLI', 'ACTIVO', '5522336699', 'jimenavaladez@gmail.com'),
(2, 'MITZI MARTINEZ SANCHEZ', 'MASM02203MDFRNTA6', 'INGENIERIA EN SISTEMAS COMPUTACIONALES', 'IZCALLI', 'ACTIVO', '5588996655', 'mitzysanchez@gmail.com'),
(3, 'OCTAVIO SANCHEZ ORTEGA', 'RTYE900902HDFLRR03', 'LICENCIATURA EN COMUNICACIÓN', 'IZCALLI', 'INACTIVO', '5599668855', 'octavio_ortega23@gmail.com'),
(4, 'MARIA ELENA CAMACHO CRISANTO', 'CACM861219MDFJMR01', 'LICENCIATURA EN EDUCACIÓN', 'IZCALLI', 'ACTIVO', '5522668854', 'mariaelenarojas@gmail.com');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `tb_alumnos_izcalli`
--
ALTER TABLE `tb_alumnos_izcalli`
  ADD PRIMARY KEY (`AL_ID`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `tb_alumnos_izcalli`
--
ALTER TABLE `tb_alumnos_izcalli`
  MODIFY `AL_ID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

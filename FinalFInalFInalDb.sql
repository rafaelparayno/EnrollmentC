-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 15, 2020 at 12:58 AM
-- Server version: 10.4.6-MariaDB
-- PHP Version: 7.3.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `final_enroll`
--

-- --------------------------------------------------------

--
-- Table structure for table `audit_trail`
--

CREATE TABLE `audit_trail` (
  `audit_id` int(11) NOT NULL,
  `date_time` varchar(50) DEFAULT NULL,
  `user` text NOT NULL,
  `action` text NOT NULL,
  `user_type` text NOT NULL,
  `username` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `audit_trail`
--

INSERT INTO `audit_trail` (`audit_id`, `date_time`, `user`, `action`, `user_type`, `username`) VALUES
(1964, '06/07/2020  07:38:52 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(1965, '06/07/2020  07:53:33 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(1966, '06/07/2020  07:55:50 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(1967, '06/07/2020  08:02:49 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(1968, '06/07/2020  08:08:53 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(1969, '06/07/2020  08:10:41 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(1970, '06/07/2020  08:11:52 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(1971, '06/07/2020  08:12:55 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(1972, '06/07/2020  08:15:22 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(1973, '06/07/2020  08:15:55 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(1974, '06/07/2020  08:31:31 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(1975, '06/07/2020  08:32:47 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(1976, '06/07/2020  08:34:07 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(1977, '06/07/2020  08:35:27 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(1978, '06/07/2020  08:36:15 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(1979, '06/07/2020  08:38:55 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(1980, '06/07/2020  08:39:40 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(1981, '06/07/2020  08:40:11 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(1982, '06/07/2020  08:42:32 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(1983, '06/07/2020  09:12:35 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(1984, '06/08/2020  09:36:37 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(1985, '06/08/2020  09:37:23 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(1986, '06/08/2020  09:42:24 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(1987, '06/08/2020  09:43:26 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(1988, '06/08/2020  09:53:12 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(1989, '06/08/2020  09:54:28 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(1990, '06/08/2020  10:21:06 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(1991, '06/08/2020  10:30:37 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(1992, '06/08/2020  10:53:03 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(1993, '06/08/2020  10:54:04 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(1994, '06/08/2020  11:01:09 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(1995, '06/08/2020  11:04:16 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(1996, '06/08/2020  11:06:49 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(1997, '06/08/2020  11:09:21 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(1998, '06/08/2020  11:11:30 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(1999, '06/08/2020  11:12:30 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2000, '06/08/2020  11:14:44 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2001, '06/08/2020  11:15:29 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2002, '06/08/2020  11:16:15 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2003, '06/08/2020  11:18:27 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2004, '06/08/2020  11:21:18 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2005, '06/08/2020  11:24:53 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2006, '06/08/2020  11:26:18 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2007, '06/08/2020  11:27:25 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2008, '06/08/2020  11:28:44 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2009, '06/08/2020  11:30:39 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2010, '06/08/2020  11:34:11 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2011, '06/08/2020  11:34:45 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2012, '06/08/2020  11:35:44 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2013, '06/08/2020  11:53:55 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2014, '06/08/2020  11:54:57 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2015, '06/09/2020  12:13:34 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2016, '06/09/2020  12:37:48 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2017, '06/09/2020  12:40:19 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2018, '06/09/2020  12:53:50 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2019, '06/09/2020  12:54:01 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2020, '06/09/2020  12:55:35 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2021, '06/09/2020  12:55:51 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2022, '06/09/2020  01:06:21 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2023, '06/09/2020  01:07:53 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2024, '06/09/2020  01:08:09 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2025, '06/09/2020  01:08:11 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2026, '06/09/2020  01:08:12 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2027, '06/09/2020  01:08:12 AM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(2028, '06/09/2020  01:08:15 AM', 'Khristine Guinto Badiana', 'Addded new User Accounts', 'System Admin', 'kbadiana2416'),
(2029, '06/09/2020  01:08:38 AM', 'Khristine Guinto Badiana', 'kbadiana2416Has Logged-out', 'System Admin', 'kbadiana2416'),
(2030, '06/09/2020  01:08:39 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2031, '06/09/2020  01:14:47 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2032, '06/09/2020  01:19:59 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2033, '06/09/2020  01:20:45 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2034, '06/09/2020  01:25:31 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2035, '06/09/2020  01:27:17 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2036, '06/09/2020  01:28:15 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2037, '06/09/2020  01:32:59 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2038, '06/09/2020  01:34:27 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2039, '06/09/2020  01:39:53 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2040, '06/09/2020  01:40:39 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2041, '06/09/2020  01:43:49 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2042, '06/09/2020  01:49:59 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2043, '06/09/2020  01:51:24 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2044, '06/09/2020  01:54:19 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2045, '06/09/2020  02:01:24 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2046, '06/09/2020  02:02:05 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2047, '06/09/2020  02:09:32 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2048, '06/09/2020  02:20:29 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2049, '06/09/2020  02:21:05 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2050, '06/09/2020  02:28:32 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2051, '06/09/2020  02:31:20 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2052, '06/09/2020  02:32:13 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2053, '06/09/2020  02:33:25 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2054, '06/09/2020  02:38:28 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2055, '06/09/2020  02:39:05 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2056, '06/09/2020  02:41:04 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2057, '06/09/2020  02:42:21 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2058, '06/09/2020  02:42:58 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2059, '06/09/2020  02:44:48 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2060, '06/09/2020  02:45:58 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2061, '06/09/2020  02:46:51 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2062, '06/09/2020  02:47:54 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2063, '06/09/2020  02:50:45 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2064, '06/09/2020  03:23:25 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2065, '06/09/2020  03:25:05 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2066, '06/09/2020  03:59:21 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2067, '06/09/2020  03:59:27 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2068, '06/09/2020  03:59:27 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2069, '06/09/2020  04:03:59 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2070, '06/09/2020  04:06:42 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2071, '06/09/2020  04:06:47 AM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2072, '06/09/2020  04:07:15 AM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(2073, '06/09/2020  04:07:17 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2074, '06/09/2020  04:07:19 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2075, '06/09/2020  04:07:19 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2076, '06/09/2020  04:07:27 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2077, '06/09/2020  04:07:28 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2078, '06/09/2020  04:18:44 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2079, '06/09/2020  04:18:47 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2080, '06/09/2020  04:18:48 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2081, '06/09/2020  04:18:51 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2082, '06/09/2020  04:18:52 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2083, '06/09/2020  05:25:03 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2084, '06/09/2020  05:25:06 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2085, '06/09/2020  05:25:07 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2086, '06/09/2020  05:25:08 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2087, '06/09/2020  05:25:08 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2088, '06/09/2020  05:26:20 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2089, '06/09/2020  05:26:22 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2090, '06/09/2020  05:26:23 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2091, '06/09/2020  05:32:33 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2092, '06/09/2020  05:32:38 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2093, '06/09/2020  05:32:39 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2094, '06/09/2020  05:32:42 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2095, '06/09/2020  05:32:43 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2096, '06/09/2020  05:33:51 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2097, '06/09/2020  05:33:53 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2098, '06/09/2020  05:33:53 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2099, '06/09/2020  05:33:56 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2100, '06/09/2020  05:33:57 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2101, '06/09/2020  05:37:15 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2102, '06/09/2020  05:43:10 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2103, '06/09/2020  05:43:12 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2104, '06/09/2020  05:43:13 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2105, '06/09/2020  05:49:56 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2106, '06/09/2020  05:51:39 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2107, '06/09/2020  05:52:47 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2108, '06/09/2020  06:24:12 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2109, '06/09/2020  06:24:29 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2110, '06/09/2020  06:24:31 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2111, '06/09/2020  06:24:32 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2112, '06/09/2020  06:24:49 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2113, '06/09/2020  06:26:31 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2114, '06/09/2020  06:38:10 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2115, '06/09/2020  06:43:03 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2116, '06/09/2020  06:43:52 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2117, '06/09/2020  06:45:55 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2118, '06/09/2020  06:49:31 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2119, '06/09/2020  06:52:38 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2120, '06/09/2020  06:52:41 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2121, '06/09/2020  06:52:42 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2122, '06/09/2020  06:53:46 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2123, '06/09/2020  06:53:51 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2124, '06/09/2020  06:53:51 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2125, '06/09/2020  06:54:43 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2126, '06/09/2020  06:56:07 AM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2127, '06/09/2020  06:56:13 AM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(2128, '06/09/2020  06:56:14 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2129, '06/09/2020  07:06:15 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2130, '06/09/2020  07:07:51 AM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2131, '06/09/2020  07:09:59 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2132, '06/09/2020  07:13:39 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2133, '06/09/2020  11:11:47 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2134, '06/09/2020  11:11:49 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2135, '06/09/2020  11:11:50 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2136, '06/09/2020  11:18:34 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2137, '06/09/2020  11:18:35 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2138, '06/09/2020  11:18:36 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2139, '06/09/2020  11:21:32 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2140, '06/09/2020  11:29:20 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2141, '06/09/2020  11:31:01 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2142, '06/09/2020  11:31:02 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2143, '06/09/2020  11:31:03 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2144, '06/09/2020  11:32:41 AM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2145, '06/09/2020  11:33:46 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2146, '06/09/2020  11:34:54 AM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2147, '06/09/2020  11:34:55 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2148, '06/09/2020  11:34:57 AM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2149, '06/09/2020  11:34:57 AM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2150, '06/09/2020  11:35:11 AM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(2151, '06/09/2020  11:35:13 AM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2152, '06/09/2020  11:35:15 AM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(2153, '06/09/2020  11:35:16 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2154, '06/09/2020  11:35:18 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2155, '06/09/2020  11:38:24 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2156, '06/09/2020  11:38:25 AM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2157, '06/09/2020  11:38:25 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2158, '06/09/2020  11:40:44 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2159, '06/09/2020  11:50:34 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2160, '06/09/2020  12:05:47 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2161, '06/09/2020  12:07:11 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2162, '06/09/2020  12:07:16 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2163, '06/09/2020  12:07:17 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2164, '06/09/2020  12:23:26 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2165, '06/09/2020  12:24:01 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2166, '06/09/2020  12:24:03 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2167, '06/09/2020  12:24:39 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2168, '06/09/2020  12:24:45 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2169, '06/09/2020  12:24:46 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2170, '06/09/2020  12:24:47 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2171, '06/09/2020  12:24:48 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2172, '06/09/2020  12:26:43 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2173, '06/09/2020  12:26:44 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2174, '06/09/2020  12:29:30 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2175, '06/09/2020  12:29:31 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2176, '06/09/2020  12:29:32 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2177, '06/09/2020  12:31:09 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2178, '06/09/2020  12:31:11 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2179, '06/09/2020  12:36:49 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2180, '06/09/2020  12:43:56 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2181, '06/09/2020  12:45:32 PM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2182, '06/09/2020  12:45:34 PM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(2183, '06/09/2020  12:45:35 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2184, '06/09/2020  12:50:23 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2185, '06/09/2020  12:50:29 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2186, '06/09/2020  12:50:30 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2187, '06/09/2020  12:56:26 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2188, '06/09/2020  12:57:54 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2189, '06/09/2020  12:59:15 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2190, '06/09/2020  01:03:54 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2191, '06/09/2020  01:03:56 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2192, '06/09/2020  01:03:57 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2193, '06/09/2020  01:04:00 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2194, '06/09/2020  01:04:01 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2195, '06/09/2020  01:17:37 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2196, '06/09/2020  01:24:13 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2197, '06/09/2020  01:24:14 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2198, '06/09/2020  01:24:15 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2199, '06/09/2020  01:25:07 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2200, '06/09/2020  01:32:37 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2201, '06/09/2020  01:37:11 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2202, '06/09/2020  01:43:14 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2203, '06/09/2020  01:44:51 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2204, '06/09/2020  01:56:06 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2205, '06/09/2020  01:59:23 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2206, '06/09/2020  02:06:36 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2207, '06/09/2020  02:06:55 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2208, '06/09/2020  02:06:56 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2209, '06/09/2020  02:08:25 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2210, '06/09/2020  02:08:30 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2211, '06/09/2020  02:15:47 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2212, '06/09/2020  02:17:20 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2213, '06/09/2020  02:18:11 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2214, '06/09/2020  02:31:22 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2215, '06/09/2020  02:32:27 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2216, '06/09/2020  02:33:11 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2217, '06/09/2020  02:38:16 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2218, '06/09/2020  02:38:19 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2219, '06/09/2020  02:38:20 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2220, '06/09/2020  02:38:45 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2221, '06/09/2020  02:39:18 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2222, '06/09/2020  02:40:44 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2223, '06/09/2020  02:40:45 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2224, '06/09/2020  02:41:03 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2225, '06/09/2020  02:41:04 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2226, '06/09/2020  02:41:32 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2227, '06/09/2020  02:42:21 PM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2228, '06/09/2020  02:43:58 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2229, '06/09/2020  02:45:44 PM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2230, '06/09/2020  02:47:57 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2231, '06/09/2020  02:47:58 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2232, '06/09/2020  02:47:59 PM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2233, '06/09/2020  02:55:31 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2234, '06/09/2020  02:55:35 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2235, '06/09/2020  02:55:36 PM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2236, '06/09/2020  02:58:17 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2237, '06/09/2020  02:58:18 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2238, '06/09/2020  02:58:19 PM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2239, '06/09/2020  02:59:10 PM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(2240, '06/09/2020  02:59:12 PM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(2241, '06/09/2020  02:59:18 PM', 'Khristine Guinto Badiana', 'kbadiana2416Has Logged-out', 'System Admin', 'kbadiana2416'),
(2242, '06/09/2020  02:59:19 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2243, '06/09/2020  02:59:21 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2244, '06/09/2020  02:59:22 PM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2245, '06/09/2020  02:59:31 PM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(2246, '06/09/2020  03:15:13 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2247, '06/09/2020  03:15:14 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2248, '06/09/2020  03:15:16 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2249, '06/09/2020  03:15:26 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2250, '06/09/2020  03:15:27 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2251, '06/09/2020  03:15:37 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2252, '06/09/2020  03:15:38 PM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(2253, '06/09/2020  03:15:45 PM', 'Khristine Guinto Badiana', 'kbadiana2416Has Logged-out', 'System Admin', 'kbadiana2416'),
(2254, '06/09/2020  03:15:46 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2255, '06/09/2020  03:15:47 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2256, '06/09/2020  03:15:48 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2257, '06/09/2020  03:15:53 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2258, '06/09/2020  03:15:53 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2259, '06/09/2020  03:16:41 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2260, '06/09/2020  07:18:25 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2261, '06/09/2020  07:18:30 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2262, '06/09/2020  07:18:31 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2263, '06/09/2020  07:18:34 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2264, '06/09/2020  07:18:35 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2265, '06/09/2020  07:19:42 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2266, '06/09/2020  07:19:44 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2267, '06/09/2020  07:19:45 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2268, '06/09/2020  07:19:49 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2269, '06/09/2020  07:19:49 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2270, '06/09/2020  07:20:18 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2271, '06/09/2020  09:57:32 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2272, '06/09/2020  09:57:36 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2273, '06/09/2020  09:57:37 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2274, '06/09/2020  09:57:38 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2275, '06/09/2020  09:57:39 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2276, '06/09/2020  09:58:18 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2277, '06/09/2020  09:58:18 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2278, '06/09/2020  11:32:31 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2279, '06/09/2020  11:32:35 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2280, '06/09/2020  11:32:35 PM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(2281, '06/09/2020  11:32:38 PM', 'Khristine Guinto Badiana', 'Addded new User Accounts', 'System Admin', 'kbadiana2416'),
(2282, '06/09/2020  11:32:47 PM', 'Khristine Guinto Badiana', 'kbadiana2416Has Logged-out', 'System Admin', 'kbadiana2416'),
(2283, '06/09/2020  11:32:49 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2284, '06/09/2020  11:36:40 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2285, '06/09/2020  11:38:10 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2286, '06/09/2020  11:38:12 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2287, '06/09/2020  11:38:12 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2288, '06/09/2020  11:38:15 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2289, '06/09/2020  11:38:16 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2290, '06/09/2020  11:39:03 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2291, '06/09/2020  11:39:05 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2292, '06/09/2020  11:39:06 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2293, '06/09/2020  11:39:45 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2294, '06/09/2020  11:40:37 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2295, '06/09/2020  11:40:39 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2296, '06/09/2020  11:40:40 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2297, '06/09/2020  11:41:06 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2298, '06/09/2020  11:41:49 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2299, '06/09/2020  11:44:09 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2300, '06/09/2020  11:44:11 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2301, '06/09/2020  11:44:11 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2302, '06/09/2020  11:44:52 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2303, '06/09/2020  11:54:44 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2304, '06/10/2020  12:28:13 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2305, '06/10/2020  12:28:15 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2306, '06/10/2020  12:28:15 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2307, '06/10/2020  12:28:33 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2308, '06/10/2020  12:28:33 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2309, '06/10/2020  12:28:35 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2310, '06/10/2020  12:28:35 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2311, '06/10/2020  01:00:53 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2312, '06/10/2020  01:00:54 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2313, '06/10/2020  01:01:47 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2314, '06/10/2020  01:01:48 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2315, '06/10/2020  02:41:46 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2316, '06/10/2020  02:53:51 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2317, '06/10/2020  02:53:55 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2318, '06/10/2020  02:53:56 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2319, '06/10/2020  02:53:57 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2320, '06/10/2020  02:53:58 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2321, '06/10/2020  02:54:15 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2322, '06/10/2020  02:54:16 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2323, '06/10/2020  02:56:26 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2324, '06/10/2020  03:01:13 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2325, '06/10/2020  03:02:26 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2326, '06/10/2020  03:03:01 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2327, '06/10/2020  03:03:02 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2328, '06/10/2020  03:04:46 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2329, '06/10/2020  03:20:46 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2330, '06/10/2020  03:23:02 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2331, '06/10/2020  03:24:19 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2332, '06/10/2020  03:25:58 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2333, '06/10/2020  03:26:00 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2334, '06/10/2020  03:26:01 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2335, '06/10/2020  03:27:34 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2336, '06/10/2020  03:29:41 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2337, '06/10/2020  03:31:07 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2338, '06/10/2020  03:31:45 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2339, '06/10/2020  03:39:13 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2340, '06/10/2020  03:42:02 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2341, '06/10/2020  03:43:27 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2342, '06/10/2020  03:49:57 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2343, '06/10/2020  03:50:58 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2344, '06/10/2020  03:55:36 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2345, '06/10/2020  04:01:20 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2346, '06/10/2020  04:06:07 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2347, '06/10/2020  04:07:39 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2348, '06/10/2020  04:09:03 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2349, '06/10/2020  04:10:41 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2350, '06/10/2020  04:11:28 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2351, '06/10/2020  04:14:26 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2352, '06/10/2020  04:15:45 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2353, '06/10/2020  04:19:20 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2354, '06/10/2020  04:21:53 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2355, '06/10/2020  04:24:44 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2356, '06/10/2020  04:31:25 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2357, '06/10/2020  04:34:18 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2358, '06/10/2020  04:35:37 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2359, '06/10/2020  04:36:49 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2360, '06/10/2020  04:44:45 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2361, '06/10/2020  04:50:10 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2362, '06/10/2020  04:52:17 PM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2363, '06/10/2020  04:52:19 PM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(2364, '06/10/2020  04:52:20 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2365, '06/10/2020  04:52:21 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2366, '06/10/2020  04:52:22 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2367, '06/10/2020  05:11:54 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2368, '06/10/2020  05:13:53 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2369, '06/10/2020  05:14:00 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2370, '06/10/2020  05:15:11 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2371, '06/10/2020  05:15:12 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2372, '06/10/2020  05:18:18 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2373, '06/10/2020  05:21:25 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2374, '06/10/2020  05:23:54 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2375, '06/10/2020  05:28:09 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2376, '06/10/2020  05:29:08 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2377, '06/10/2020  05:30:53 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2378, '06/10/2020  05:56:27 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2379, '06/10/2020  05:57:42 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2380, '06/10/2020  06:02:35 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2381, '06/10/2020  06:02:38 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2382, '06/10/2020  06:02:39 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2383, '06/10/2020  06:03:08 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2384, '06/10/2020  06:05:32 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2385, '06/10/2020  06:05:39 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2386, '06/10/2020  06:05:40 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2387, '06/10/2020  06:15:02 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2388, '06/10/2020  06:15:33 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2389, '06/10/2020  06:16:17 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2390, '06/10/2020  06:16:18 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2391, '06/10/2020  06:16:19 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2392, '06/10/2020  06:17:49 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2393, '06/10/2020  06:17:50 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2394, '06/10/2020  06:17:51 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2395, '06/10/2020  06:22:02 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2396, '06/10/2020  06:22:04 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2397, '06/10/2020  06:22:05 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2398, '06/10/2020  06:23:10 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2399, '06/10/2020  06:23:13 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2400, '06/10/2020  06:23:13 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2401, '06/10/2020  06:24:14 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2402, '06/10/2020  06:24:15 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2403, '06/10/2020  06:24:16 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2404, '06/10/2020  06:25:54 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2405, '06/10/2020  06:26:01 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2406, '06/10/2020  06:26:42 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2407, '06/10/2020  06:36:04 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188');
INSERT INTO `audit_trail` (`audit_id`, `date_time`, `user`, `action`, `user_type`, `username`) VALUES
(2408, '06/10/2020  06:37:22 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2409, '06/10/2020  06:43:34 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2410, '06/10/2020  06:45:40 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2411, '06/10/2020  06:46:33 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2412, '06/10/2020  06:47:11 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2413, '06/10/2020  06:47:14 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2414, '06/10/2020  06:47:15 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2415, '06/10/2020  06:51:12 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2416, '06/10/2020  06:51:20 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2417, '06/10/2020  06:51:21 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2418, '06/10/2020  06:51:53 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2419, '06/10/2020  06:52:25 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2420, '06/10/2020  06:56:24 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2421, '06/10/2020  06:57:16 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2422, '06/10/2020  06:58:22 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2423, '06/10/2020  06:58:53 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2424, '06/10/2020  06:59:43 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2425, '06/10/2020  07:02:52 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2426, '06/10/2020  07:02:53 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2427, '06/10/2020  07:04:55 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2428, '06/10/2020  07:04:57 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2429, '06/10/2020  07:04:57 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2430, '06/10/2020  07:05:04 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2431, '06/10/2020  07:05:04 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2432, '06/10/2020  07:06:24 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2433, '06/10/2020  07:06:26 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2434, '06/10/2020  07:06:27 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2435, '06/10/2020  07:08:58 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2436, '06/10/2020  07:18:12 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2437, '06/10/2020  07:18:54 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2438, '06/10/2020  07:18:57 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2439, '06/10/2020  07:18:57 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2440, '06/10/2020  07:28:15 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2441, '06/10/2020  07:29:32 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2442, '06/10/2020  07:32:01 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2443, '06/10/2020  07:33:18 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2444, '06/10/2020  07:34:20 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2445, '06/10/2020  07:37:15 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2446, '06/10/2020  07:38:18 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2447, '06/10/2020  07:39:52 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2448, '06/10/2020  07:46:05 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2449, '06/10/2020  07:52:33 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2450, '06/10/2020  07:53:43 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2451, '06/10/2020  07:53:44 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2452, '06/10/2020  07:53:49 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2453, '06/10/2020  07:53:50 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2454, '06/10/2020  07:59:54 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2455, '06/10/2020  08:01:03 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2456, '06/10/2020  08:58:57 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2457, '06/10/2020  08:58:58 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2458, '06/10/2020  08:58:59 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2459, '06/10/2020  08:59:00 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2460, '06/10/2020  08:59:01 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2461, '06/10/2020  08:59:07 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2462, '06/10/2020  08:59:07 PM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2463, '06/10/2020  10:17:44 PM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2464, '06/10/2020  10:46:03 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2465, '06/10/2020  10:46:12 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2466, '06/10/2020  10:46:12 PM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2467, '06/10/2020  10:48:08 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2468, '06/10/2020  10:48:10 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2469, '06/10/2020  10:48:10 PM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2470, '06/10/2020  10:48:49 PM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2471, '06/10/2020  10:50:40 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2472, '06/10/2020  10:50:41 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2473, '06/10/2020  10:50:42 PM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2474, '06/10/2020  10:51:43 PM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2475, '06/10/2020  10:53:44 PM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2476, '06/10/2020  11:07:16 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2477, '06/10/2020  11:07:48 PM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2478, '06/10/2020  11:16:02 PM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2479, '06/10/2020  11:55:05 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2480, '06/10/2020  11:55:06 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2481, '06/10/2020  11:55:07 PM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2482, '06/11/2020  12:09:40 AM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2483, '06/11/2020  12:15:02 AM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2484, '06/11/2020  12:15:48 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2485, '06/11/2020  12:15:56 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2486, '06/11/2020  12:15:58 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2487, '06/11/2020  12:16:23 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2488, '06/11/2020  12:16:25 AM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2489, '06/11/2020  12:17:50 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2490, '06/11/2020  12:17:51 AM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2491, '06/11/2020  12:17:52 AM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2492, '06/11/2020  12:19:15 AM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(2493, '06/11/2020  12:19:17 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2494, '06/11/2020  12:19:20 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2495, '06/11/2020  12:19:21 AM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(2496, '06/11/2020  12:19:23 AM', 'Khristine Guinto Badiana', 'Addded new User Accounts', 'System Admin', 'kbadiana2416'),
(2497, '06/11/2020  12:19:52 AM', 'Khristine Guinto Badiana', 'kbadiana2416Has Logged-out', 'System Admin', 'kbadiana2416'),
(2498, '06/11/2020  12:19:53 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2499, '06/11/2020  12:19:54 AM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2500, '06/11/2020  12:19:55 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2501, '06/11/2020  12:19:56 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2502, '06/11/2020  12:19:57 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2503, '06/11/2020  12:19:58 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2504, '06/11/2020  12:19:58 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2505, '06/11/2020  12:20:00 AM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2506, '06/11/2020  12:20:00 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2507, '06/11/2020  12:22:28 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2508, '06/11/2020  12:22:30 AM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2509, '06/11/2020  12:22:45 AM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(2510, '06/11/2020  12:22:50 AM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(2511, '06/11/2020  12:23:23 AM', 'Khristine Guinto Badiana', 'kbadiana2416Has Logged-out', 'System Admin', 'kbadiana2416'),
(2512, '06/11/2020  12:23:33 AM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(2513, '06/11/2020  12:23:44 AM', 'Khristine Guinto Badiana', 'kbadiana2416Has Logged-out', 'System Admin', 'kbadiana2416'),
(2514, '06/11/2020  12:23:55 AM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(2515, '06/11/2020  12:24:05 AM', 'Khristine Guinto Badiana', 'Reset Password of b.ben', 'System Admin', 'kbadiana2416'),
(2516, '06/11/2020  12:24:08 AM', 'Khristine Guinto Badiana', 'Reset Password of b.ben', 'System Admin', 'kbadiana2416'),
(2517, '06/11/2020  12:24:27 AM', 'Khristine Guinto Badiana', 'kbadiana2416Has Logged-out', 'System Admin', 'kbadiana2416'),
(2518, '06/11/2020  12:24:36 AM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(2519, '06/11/2020  12:24:45 AM', 'Khristine Guinto Badiana', 'Delete a User Account ', 'System Admin', 'kbadiana2416'),
(2520, '06/11/2020  12:24:47 AM', 'Khristine Guinto Badiana', 'kbadiana2416Has Logged-out', 'System Admin', 'kbadiana2416'),
(2521, '06/11/2020  12:24:50 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2522, '06/11/2020  12:24:51 AM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2523, '06/11/2020  12:24:52 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2524, '06/11/2020  12:25:13 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2525, '06/11/2020  12:25:15 AM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2526, '06/11/2020  12:25:59 AM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(2527, '06/11/2020  12:26:00 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2528, '06/11/2020  12:26:15 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2529, '06/11/2020  12:26:17 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2530, '06/11/2020  12:26:19 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2531, '06/11/2020  12:26:19 AM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(2532, '06/11/2020  12:26:36 AM', 'Khristine Guinto Badiana', 'Reset Password of R.parayno', 'System Admin', 'kbadiana2416'),
(2533, '06/11/2020  12:26:51 AM', 'Khristine Guinto Badiana', 'kbadiana2416Has Logged-out', 'System Admin', 'kbadiana2416'),
(2534, '06/11/2020  12:26:54 AM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(2535, '06/11/2020  12:27:00 AM', 'Khristine Guinto Badiana', 'kbadiana2416Has Logged-out', 'System Admin', 'kbadiana2416'),
(2536, '06/11/2020  12:27:07 AM', 'parayno Guiterrez Rafael', 'User has been Login', 'Teacher', 'R.parayno'),
(2537, '06/11/2020  12:27:44 AM', 'parayno Guiterrez Rafael', 'R.paraynoHas Logged-out', 'Teacher', 'R.parayno'),
(2538, '06/11/2020  12:27:47 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2539, '06/11/2020  12:28:57 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2540, '06/11/2020  12:29:00 AM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2541, '06/11/2020  12:29:47 AM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(2542, '06/11/2020  12:29:49 AM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2543, '06/11/2020  12:29:51 AM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(2544, '06/11/2020  12:30:00 AM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(2545, '06/11/2020  12:30:07 AM', 'Khristine Guinto Badiana', 'kbadiana2416Has Logged-out', 'System Admin', 'kbadiana2416'),
(2546, '06/11/2020  12:30:11 AM', 'parayno Guiterrez Rafael', 'User has been Login', 'Teacher', 'R.parayno'),
(2547, '06/11/2020  12:31:14 AM', 'parayno Guiterrez Rafael', 'R.paraynoHas Logged-out', 'Teacher', 'R.parayno'),
(2548, '06/11/2020  12:31:16 AM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2549, '06/11/2020  12:31:24 AM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(2550, '06/11/2020  12:31:26 AM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(2551, '06/11/2020  12:31:28 AM', 'Khristine Guinto Badiana', 'kbadiana2416Has Logged-out', 'System Admin', 'kbadiana2416'),
(2552, '06/11/2020  12:31:29 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2553, '06/11/2020  12:32:19 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2554, '06/11/2020  12:32:20 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2555, '06/11/2020  12:32:27 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2556, '06/11/2020  12:32:28 AM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2557, '06/11/2020  12:32:29 AM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(2558, '06/11/2020  12:32:30 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2559, '06/11/2020  12:32:31 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2560, '06/11/2020  12:32:32 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2561, '06/11/2020  12:32:38 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2562, '06/11/2020  12:32:39 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2563, '06/11/2020  12:34:02 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2564, '06/11/2020  12:34:03 AM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(2565, '06/11/2020  12:34:15 AM', 'Khristine Guinto Badiana', 'Reset Password of p.nardo', 'System Admin', 'kbadiana2416'),
(2566, '06/11/2020  12:34:35 AM', 'Khristine Guinto Badiana', 'kbadiana2416Has Logged-out', 'System Admin', 'kbadiana2416'),
(2567, '06/11/2020  12:34:45 AM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(2568, '06/11/2020  12:35:25 AM', 'Khristine Guinto Badiana', 'Reset Password of p.nardo', 'System Admin', 'kbadiana2416'),
(2569, '06/11/2020  12:35:39 AM', 'Khristine Guinto Badiana', 'kbadiana2416Has Logged-out', 'System Admin', 'kbadiana2416'),
(2570, '06/11/2020  12:35:43 AM', 'nardo  putik', 'User has been Login', 'Teacher', 'p.nardo'),
(2571, '06/11/2020  12:36:03 AM', 'nardo  putik', 'p.nardoHas Logged-out', 'Teacher', 'p.nardo'),
(2572, '06/11/2020  12:36:06 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2573, '06/11/2020  12:36:07 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2574, '06/11/2020  12:36:08 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2575, '06/11/2020  12:36:47 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2576, '06/11/2020  12:36:52 AM', 'nardo  putik', 'User has been Login', 'Teacher', 'p.nardo'),
(2577, '06/11/2020  12:37:03 AM', 'nardo  putik', 'p.nardoHas Logged-out', 'Teacher', 'p.nardo'),
(2578, '06/11/2020  12:37:04 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2579, '06/11/2020  12:37:05 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2580, '06/11/2020  12:37:06 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2581, '06/11/2020  12:37:14 AM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2582, '06/11/2020  12:37:17 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2583, '06/11/2020  12:37:18 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2584, '06/11/2020  12:37:19 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2585, '06/11/2020  12:37:24 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2586, '06/11/2020  12:37:26 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2587, '06/11/2020  12:37:56 AM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2588, '06/11/2020  12:37:57 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2589, '06/11/2020  12:37:58 AM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2590, '06/11/2020  12:37:58 AM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2591, '06/11/2020  12:38:00 AM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(2592, '06/11/2020  12:38:05 AM', 'nardo  putik', 'User has been Login', 'Teacher', 'p.nardo'),
(2593, '06/11/2020  12:38:26 AM', 'nardo  putik', 'p.nardoHas Logged-out', 'Teacher', 'p.nardo'),
(2594, '06/11/2020  12:38:28 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2595, '06/11/2020  12:38:48 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2596, '06/11/2020  12:38:49 AM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2597, '06/11/2020  12:38:58 AM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(2598, '06/11/2020  12:39:01 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2599, '06/11/2020  12:39:52 AM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2600, '06/11/2020  12:39:56 AM', 'nardo  putik', 'User has been Login', 'Teacher', 'p.nardo'),
(2601, '06/11/2020  12:40:06 AM', 'nardo  putik', 'p.nardoHas Logged-out', 'Teacher', 'p.nardo'),
(2602, '06/11/2020  12:40:08 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2603, '06/11/2020  12:40:51 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2604, '06/11/2020  12:40:53 AM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2605, '06/11/2020  12:41:31 AM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(2606, '06/11/2020  12:42:20 AM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2607, '06/11/2020  12:56:00 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2608, '06/11/2020  12:56:02 AM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2609, '06/11/2020  12:56:02 AM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2610, '06/11/2020  12:59:50 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2611, '06/11/2020  12:59:51 AM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2612, '06/11/2020  12:59:52 AM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2613, '06/11/2020  01:00:22 AM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2614, '06/11/2020  01:05:51 AM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2615, '06/11/2020  01:05:54 AM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(2616, '06/11/2020  01:05:56 AM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2617, '06/11/2020  01:07:20 AM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(2618, '06/11/2020  01:07:34 AM', 'nardo  putik', 'User has been Login', 'Teacher', 'p.nardo'),
(2619, '06/11/2020  01:09:55 AM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2620, '06/11/2020  01:09:56 AM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(2621, '06/11/2020  01:10:06 AM', 'nardo  putik', 'User has been Login', 'Teacher', 'p.nardo'),
(2622, '06/11/2020  01:10:39 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2623, '06/11/2020  01:10:40 AM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2624, '06/11/2020  01:10:41 AM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2625, '06/11/2020  01:10:44 AM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(2626, '06/11/2020  01:10:50 AM', 'nardo  putik', 'User has been Login', 'Teacher', 'p.nardo'),
(2627, '06/11/2020  01:12:19 AM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2628, '06/11/2020  01:12:20 AM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(2629, '06/11/2020  01:12:21 AM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2630, '06/11/2020  01:12:31 AM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(2631, '06/11/2020  01:12:36 AM', 'nardo  putik', 'User has been Login', 'Teacher', 'p.nardo'),
(2632, '06/11/2020  01:12:46 AM', 'nardo  putik', 'p.nardoHas Logged-out', 'Teacher', 'p.nardo'),
(2633, '06/11/2020  01:12:48 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2634, '06/11/2020  01:14:11 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2635, '06/11/2020  01:14:13 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2636, '06/11/2020  01:15:47 AM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2637, '06/11/2020  01:15:50 AM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2638, '06/11/2020  01:15:51 AM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(2639, '06/11/2020  01:15:57 AM', 'nardo  putik', 'User has been Login', 'Teacher', 'p.nardo'),
(2640, '06/11/2020  01:17:45 AM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2641, '06/11/2020  01:17:49 AM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(2642, '06/11/2020  01:17:51 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2643, '06/11/2020  01:17:53 AM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2644, '06/11/2020  01:17:54 AM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2645, '06/11/2020  01:18:07 AM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(2646, '06/11/2020  01:18:18 AM', 'nardo  putik', 'User has been Login', 'Teacher', 'p.nardo'),
(2647, '06/11/2020  01:19:49 AM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2648, '06/11/2020  01:21:33 AM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2649, '06/11/2020  01:24:35 AM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2650, '06/11/2020  01:25:48 AM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2651, '06/11/2020  01:26:25 AM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(2652, '06/11/2020  01:26:35 AM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2653, '06/11/2020  01:33:05 AM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2654, '06/11/2020  01:33:29 AM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(2655, '06/11/2020  02:20:13 AM', '  ', 'Has Logged-out', '', ''),
(2656, '06/11/2020  02:20:41 AM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2657, '06/11/2020  02:20:43 AM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(2658, '06/11/2020  02:20:46 AM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2659, '06/11/2020  02:21:18 AM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(2660, '06/11/2020  02:21:20 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2661, '06/11/2020  02:21:22 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2662, '06/11/2020  02:21:22 AM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2663, '06/11/2020  02:21:58 AM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(2664, '06/11/2020  02:21:59 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2665, '06/11/2020  02:22:00 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2666, '06/11/2020  02:22:00 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2667, '06/11/2020  02:23:48 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2668, '06/11/2020  11:50:43 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2669, '06/11/2020  11:51:01 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2670, '06/11/2020  11:57:57 AM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(2671, '06/11/2020  11:58:02 AM', 'Khristine Guinto Badiana', 'Backup a Data from ', 'System Admin', 'kbadiana2416'),
(2672, '06/11/2020  11:58:30 AM', 'Khristine Guinto Badiana', 'kbadiana2416Has Logged-out', 'System Admin', 'kbadiana2416'),
(2673, '06/11/2020  12:09:12 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2674, '06/11/2020  12:10:32 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2675, '06/11/2020  12:10:39 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2676, '06/11/2020  12:10:41 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2677, '06/11/2020  12:10:41 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2678, '06/11/2020  12:10:42 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2679, '06/11/2020  12:10:43 PM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2680, '06/11/2020  12:10:44 PM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(2681, '06/11/2020  12:10:44 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2682, '06/11/2020  12:13:01 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2683, '06/11/2020  12:13:03 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2684, '06/11/2020  12:13:03 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2685, '06/11/2020  12:15:47 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2686, '06/11/2020  12:15:48 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2687, '06/11/2020  12:15:49 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2688, '06/11/2020  12:21:02 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2689, '06/11/2020  12:23:05 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2690, '06/11/2020  12:23:40 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2691, '06/11/2020  12:23:41 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2692, '06/11/2020  12:23:41 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2693, '06/11/2020  12:28:35 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2694, '06/11/2020  12:28:51 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2695, '06/11/2020  12:48:11 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2696, '06/11/2020  12:50:23 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2697, '06/11/2020  12:52:12 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2698, '06/11/2020  12:53:19 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2699, '06/11/2020  12:58:21 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2700, '06/11/2020  12:59:16 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2701, '06/11/2020  01:02:16 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2702, '06/11/2020  01:13:34 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2703, '06/11/2020  01:15:15 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2704, '06/11/2020  01:16:47 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2705, '06/11/2020  01:18:48 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2706, '06/11/2020  01:19:18 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2707, '06/11/2020  01:19:25 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2708, '06/11/2020  01:19:26 PM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(2709, '06/11/2020  01:19:33 PM', 'Khristine Guinto Badiana', 'kbadiana2416Has Logged-out', 'System Admin', 'kbadiana2416'),
(2710, '06/11/2020  01:19:34 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2711, '06/11/2020  01:19:39 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2712, '06/11/2020  01:19:40 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2713, '06/11/2020  01:19:49 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2714, '06/11/2020  01:19:50 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2715, '06/11/2020  01:21:14 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2716, '06/11/2020  01:21:27 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2717, '06/11/2020  01:21:28 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2718, '06/11/2020  01:21:38 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2719, '06/11/2020  01:21:38 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2720, '06/11/2020  01:21:46 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2721, '06/11/2020  01:21:47 PM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2722, '06/11/2020  01:21:48 PM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(2723, '06/11/2020  01:21:50 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2724, '06/11/2020  01:22:07 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2725, '06/11/2020  01:22:08 PM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(2726, '06/11/2020  01:22:14 PM', 'Khristine Guinto Badiana', 'kbadiana2416Has Logged-out', 'System Admin', 'kbadiana2416'),
(2727, '06/11/2020  01:22:14 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2728, '06/11/2020  01:26:14 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2729, '06/11/2020  01:27:45 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2730, '06/11/2020  01:29:23 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2731, '06/11/2020  01:30:20 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2732, '06/11/2020  01:31:23 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2733, '06/11/2020  01:31:55 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2734, '06/11/2020  01:32:09 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2735, '06/11/2020  01:32:10 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2736, '06/11/2020  01:36:49 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2737, '06/11/2020  01:38:00 PM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(2738, '06/11/2020  01:38:03 PM', 'Khristine Guinto Badiana', 'kbadiana2416Has Logged-out', 'System Admin', 'kbadiana2416'),
(2739, '06/11/2020  01:38:04 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2740, '06/11/2020  01:38:15 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2741, '06/11/2020  01:40:18 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2742, '06/11/2020  01:41:21 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2743, '06/11/2020  01:42:13 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2744, '06/11/2020  01:42:27 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2745, '06/11/2020  01:42:29 PM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(2746, '06/11/2020  01:42:30 PM', 'Khristine Guinto Badiana', 'kbadiana2416Has Logged-out', 'System Admin', 'kbadiana2416'),
(2747, '06/11/2020  01:42:31 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2748, '06/11/2020  01:42:32 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2749, '06/11/2020  01:42:34 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2750, '06/11/2020  01:42:41 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2751, '06/11/2020  01:42:42 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2752, '06/11/2020  01:42:50 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2753, '06/11/2020  01:45:12 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2754, '06/11/2020  01:45:14 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2755, '06/11/2020  01:45:16 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2756, '06/11/2020  01:45:22 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2757, '06/11/2020  01:45:23 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2758, '06/11/2020  01:45:25 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2759, '06/11/2020  01:45:26 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2760, '06/11/2020  01:45:30 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2761, '06/11/2020  01:45:31 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2762, '06/11/2020  01:45:38 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2763, '06/11/2020  01:45:39 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2764, '06/11/2020  01:48:11 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2765, '06/11/2020  01:48:13 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2766, '06/11/2020  01:48:13 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2767, '06/11/2020  01:48:15 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2768, '06/11/2020  01:48:16 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2769, '06/11/2020  01:48:45 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2770, '06/11/2020  01:48:46 PM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(2771, '06/11/2020  01:48:49 PM', 'Khristine Guinto Badiana', 'kbadiana2416Has Logged-out', 'System Admin', 'kbadiana2416'),
(2772, '06/11/2020  01:48:50 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2773, '06/11/2020  01:48:54 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2774, '06/11/2020  01:48:54 PM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(2775, '06/11/2020  01:49:01 PM', 'Khristine Guinto Badiana', 'kbadiana2416Has Logged-out', 'System Admin', 'kbadiana2416'),
(2776, '06/11/2020  01:49:03 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2777, '06/11/2020  01:49:07 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2778, '06/11/2020  01:49:08 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2779, '06/11/2020  01:49:09 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2780, '06/11/2020  01:49:10 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2781, '06/11/2020  01:49:14 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2782, '06/11/2020  01:49:15 PM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2783, '06/11/2020  01:49:26 PM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(2784, '06/11/2020  01:49:27 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2785, '06/11/2020  01:49:32 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2786, '06/11/2020  01:49:34 PM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(2787, '06/11/2020  01:49:38 PM', 'Khristine Guinto Badiana', 'kbadiana2416Has Logged-out', 'System Admin', 'kbadiana2416'),
(2788, '06/11/2020  01:49:39 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2789, '06/11/2020  01:49:47 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2790, '06/11/2020  01:49:49 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2791, '06/11/2020  01:49:53 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2792, '06/11/2020  01:49:54 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2793, '06/11/2020  01:50:00 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2794, '06/11/2020  01:50:01 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2795, '06/11/2020  01:50:50 PM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2796, '06/11/2020  01:50:53 PM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(2797, '06/11/2020  01:50:54 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2798, '06/11/2020  01:50:56 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2799, '06/11/2020  01:50:57 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2800, '06/11/2020  01:51:00 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2801, '06/11/2020  01:51:01 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2802, '06/11/2020  01:51:04 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2803, '06/11/2020  01:51:04 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2804, '06/11/2020  01:51:18 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2805, '06/11/2020  01:51:19 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2806, '06/11/2020  01:52:26 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2807, '06/11/2020  01:52:29 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2808, '06/11/2020  01:52:30 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2809, '06/11/2020  01:57:50 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2810, '06/11/2020  02:01:17 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2811, '06/11/2020  02:04:47 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2812, '06/11/2020  02:04:48 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2813, '06/11/2020  02:04:48 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2814, '06/11/2020  02:04:49 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2815, '06/11/2020  02:04:50 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2816, '06/11/2020  02:04:52 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2817, '06/11/2020  02:04:53 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2818, '06/11/2020  02:05:56 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2819, '06/11/2020  02:05:58 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2820, '06/11/2020  02:05:59 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2821, '06/11/2020  02:08:02 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2822, '06/11/2020  02:08:52 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2823, '06/11/2020  02:13:37 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2824, '06/11/2020  02:19:31 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2825, '06/11/2020  07:22:09 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2826, '06/11/2020  07:25:16 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2827, '06/11/2020  07:25:17 PM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(2828, '06/11/2020  07:25:25 PM', 'Khristine Guinto Badiana', 'kbadiana2416Has Logged-out', 'System Admin', 'kbadiana2416'),
(2829, '06/11/2020  07:25:35 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2830, '06/11/2020  07:28:49 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2831, '06/11/2020  07:28:50 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2832, '06/11/2020  07:29:34 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2833, '06/11/2020  07:29:35 PM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2834, '06/11/2020  07:29:56 PM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(2835, '06/11/2020  07:29:58 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2836, '06/11/2020  07:30:01 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2837, '06/11/2020  07:30:03 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2838, '06/11/2020  07:30:09 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2839, '06/11/2020  07:30:09 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2840, '06/11/2020  07:30:43 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2841, '06/11/2020  07:30:44 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2842, '06/11/2020  07:30:45 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2843, '06/11/2020  07:30:45 PM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2844, '06/11/2020  07:31:02 PM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(2845, '06/11/2020  07:31:03 PM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(2846, '06/11/2020  07:31:04 PM', 'Khristine Guinto Badiana', 'kbadiana2416Has Logged-out', 'System Admin', 'kbadiana2416'),
(2847, '06/11/2020  07:31:05 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2848, '06/11/2020  07:31:06 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2849, '06/11/2020  07:32:08 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2850, '06/11/2020  07:32:10 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2851, '06/11/2020  07:32:10 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2852, '06/11/2020  07:36:13 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2853, '06/11/2020  07:36:13 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2854, '06/11/2020  07:36:20 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2855, '06/11/2020  07:36:21 PM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2856, '06/11/2020  07:36:24 PM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(2857, '06/11/2020  07:36:25 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2858, '06/11/2020  07:37:00 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2859, '06/11/2020  07:39:21 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2860, '06/11/2020  07:39:23 PM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'kbadiana2416');
INSERT INTO `audit_trail` (`audit_id`, `date_time`, `user`, `action`, `user_type`, `username`) VALUES
(2861, '06/11/2020  07:48:52 PM', 'Khristine Guinto Badiana', 'kbadiana2416Has Logged-out', 'System Admin', 'kbadiana2416'),
(2862, '06/11/2020  07:48:53 PM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2863, '06/11/2020  07:49:55 PM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(2864, '06/11/2020  07:49:56 PM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2865, '06/11/2020  07:51:39 PM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(2866, '06/11/2020  07:51:41 PM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2867, '06/11/2020  07:51:43 PM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(2868, '06/11/2020  07:51:47 PM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(2869, '06/11/2020  07:52:52 PM', 'Khristine Guinto Badiana', 'kbadiana2416Has Logged-out', 'System Admin', 'kbadiana2416'),
(2870, '06/11/2020  07:52:53 PM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2871, '06/11/2020  07:53:01 PM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(2872, '06/11/2020  08:13:25 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2873, '06/11/2020  08:13:26 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2874, '06/11/2020  08:13:27 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2875, '06/11/2020  08:16:11 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2876, '06/11/2020  08:18:31 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2877, '06/11/2020  08:18:32 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2878, '06/11/2020  08:18:33 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2879, '06/11/2020  08:19:21 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2880, '06/11/2020  08:19:23 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2881, '06/11/2020  08:19:23 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2882, '06/11/2020  08:19:24 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2883, '06/11/2020  08:19:25 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2884, '06/11/2020  08:25:31 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2885, '06/11/2020  08:25:32 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2886, '06/11/2020  08:25:33 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2887, '06/11/2020  08:30:37 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2888, '06/11/2020  08:34:12 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2889, '06/11/2020  08:51:22 PM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2890, '06/11/2020  08:51:23 PM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(2891, '06/11/2020  08:51:24 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2892, '06/11/2020  08:52:33 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2893, '06/11/2020  08:52:34 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2894, '06/11/2020  08:52:35 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2895, '06/11/2020  09:04:24 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2896, '06/11/2020  09:04:26 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2897, '06/11/2020  09:04:27 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2898, '06/11/2020  09:05:34 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2899, '06/11/2020  09:06:14 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2900, '06/11/2020  09:06:14 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2901, '06/11/2020  09:06:25 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2902, '06/11/2020  09:07:38 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2903, '06/11/2020  09:07:39 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2904, '06/11/2020  09:07:40 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2905, '06/11/2020  09:07:40 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2906, '06/11/2020  09:07:41 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2907, '06/11/2020  09:09:51 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2908, '06/11/2020  09:10:19 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2909, '06/11/2020  09:10:20 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2910, '06/11/2020  09:13:41 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2911, '06/11/2020  09:14:50 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2912, '06/11/2020  09:14:58 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2913, '06/11/2020  09:15:14 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2914, '06/11/2020  09:15:15 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2915, '06/11/2020  09:23:43 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2916, '06/11/2020  09:27:24 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2917, '06/11/2020  09:27:26 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2918, '06/11/2020  09:27:27 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2919, '06/12/2020  11:19:34 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2920, '06/12/2020  11:19:36 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2921, '06/12/2020  11:19:37 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2922, '06/12/2020  11:19:39 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2923, '06/12/2020  11:19:45 AM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(2924, '06/12/2020  11:19:50 AM', 'Khristine Guinto Badiana', 'kbadiana2416Has Logged-out', 'System Admin', 'kbadiana2416'),
(2925, '06/12/2020  11:19:51 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2926, '06/12/2020  11:19:53 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2927, '06/12/2020  11:19:55 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2928, '06/12/2020  11:20:21 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2929, '06/12/2020  11:20:26 AM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(2930, '06/12/2020  11:20:30 AM', 'Khristine Guinto Badiana', 'kbadiana2416Has Logged-out', 'System Admin', 'kbadiana2416'),
(2931, '06/12/2020  11:20:31 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2932, '06/12/2020  11:20:36 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2933, '06/12/2020  11:20:37 AM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(2934, '06/12/2020  11:20:45 AM', 'Khristine Guinto Badiana', 'kbadiana2416Has Logged-out', 'System Admin', 'kbadiana2416'),
(2935, '06/12/2020  11:20:46 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2936, '06/12/2020  11:21:00 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2937, '06/12/2020  11:21:01 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2938, '06/12/2020  11:22:50 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2939, '06/12/2020  11:24:57 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2940, '06/12/2020  11:25:52 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2941, '06/12/2020  11:26:32 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2942, '06/12/2020  11:27:02 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2943, '06/12/2020  11:28:04 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2944, '06/12/2020  11:29:18 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2945, '06/12/2020  11:30:50 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2946, '06/12/2020  11:33:14 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2947, '06/12/2020  11:34:53 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2948, '06/12/2020  11:36:06 AM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(2949, '06/12/2020  11:36:14 AM', 'Khristine Guinto Badiana', 'kbadiana2416Has Logged-out', 'System Admin', 'kbadiana2416'),
(2950, '06/12/2020  11:36:19 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2951, '06/12/2020  11:36:40 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2952, '06/12/2020  11:36:41 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2953, '06/12/2020  11:36:42 AM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2954, '06/12/2020  11:36:43 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2955, '06/12/2020  11:38:00 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2956, '06/12/2020  11:38:02 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2957, '06/12/2020  11:38:03 AM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2958, '06/12/2020  11:38:04 AM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(2959, '06/12/2020  11:38:11 AM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(2960, '06/12/2020  11:38:11 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2961, '06/12/2020  11:38:19 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2962, '06/12/2020  11:38:20 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2963, '06/12/2020  11:38:56 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2964, '06/12/2020  11:38:58 AM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(2965, '06/12/2020  11:39:03 AM', 'Khristine Guinto Badiana', 'kbadiana2416Has Logged-out', 'System Admin', 'kbadiana2416'),
(2966, '06/12/2020  11:39:04 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2967, '06/12/2020  11:39:05 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2968, '06/12/2020  11:39:06 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2969, '06/12/2020  11:39:14 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2970, '06/12/2020  11:39:15 AM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(2971, '06/12/2020  11:39:20 AM', 'Khristine Guinto Badiana', 'kbadiana2416Has Logged-out', 'System Admin', 'kbadiana2416'),
(2972, '06/12/2020  11:39:22 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2973, '06/12/2020  11:39:28 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2974, '06/12/2020  11:39:28 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2975, '06/12/2020  11:39:32 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2976, '06/12/2020  11:39:33 AM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(2977, '06/12/2020  11:39:38 AM', 'Khristine Guinto Badiana', 'kbadiana2416Has Logged-out', 'System Admin', 'kbadiana2416'),
(2978, '06/12/2020  11:39:39 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2979, '06/12/2020  11:39:52 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2980, '06/12/2020  11:39:53 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2981, '06/12/2020  11:39:59 AM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2982, '06/12/2020  11:40:00 AM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(2983, '06/12/2020  11:40:09 AM', 'Khristine Guinto Badiana', 'kbadiana2416Has Logged-out', 'System Admin', 'kbadiana2416'),
(2984, '06/12/2020  11:40:10 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2985, '06/12/2020  11:40:18 AM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2986, '06/12/2020  11:40:20 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2987, '06/12/2020  11:40:22 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2988, '06/12/2020  11:40:23 AM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(2989, '06/12/2020  11:40:27 AM', 'Khristine Guinto Badiana', 'kbadiana2416Has Logged-out', 'System Admin', 'kbadiana2416'),
(2990, '06/12/2020  11:40:28 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2991, '06/12/2020  11:42:11 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2992, '06/12/2020  11:42:13 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(2993, '06/12/2020  11:42:14 AM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(2994, '06/12/2020  11:42:16 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(2995, '06/12/2020  11:44:06 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(2996, '06/12/2020  11:44:08 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2997, '06/12/2020  11:44:54 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(2998, '06/12/2020  11:44:56 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(2999, '06/12/2020  11:45:14 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3000, '06/12/2020  11:45:16 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3001, '06/12/2020  11:48:00 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3002, '06/12/2020  11:50:01 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3003, '06/12/2020  11:51:27 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3004, '06/12/2020  11:58:38 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3005, '06/12/2020  11:59:49 AM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(3006, '06/12/2020  11:59:50 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3007, '06/12/2020  11:59:54 AM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(3008, '06/12/2020  11:59:55 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3009, '06/12/2020  11:59:56 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3010, '06/12/2020  11:59:57 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3011, '06/12/2020  12:05:56 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3012, '06/12/2020  12:07:04 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3013, '06/12/2020  12:11:25 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3014, '06/12/2020  12:16:31 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3015, '06/12/2020  12:17:31 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3016, '06/12/2020  12:17:32 PM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(3017, '06/12/2020  12:17:33 PM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(3018, '06/12/2020  12:17:34 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3019, '06/12/2020  12:17:36 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3020, '06/12/2020  12:17:37 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3021, '06/12/2020  12:19:41 PM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(3022, '06/12/2020  12:19:43 PM', 'Khristine Guinto Badiana', 'kbadiana2416Has Logged-out', 'System Admin', 'kbadiana2416'),
(3023, '06/12/2020  12:19:44 PM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(3024, '06/12/2020  12:19:49 PM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(3025, '06/12/2020  12:19:53 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3026, '06/12/2020  12:30:52 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3027, '06/12/2020  12:38:03 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3028, '06/12/2020  12:39:52 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3029, '06/12/2020  12:39:53 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3030, '06/12/2020  12:39:54 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3031, '06/12/2020  12:42:12 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3032, '06/12/2020  12:42:29 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3033, '06/12/2020  12:42:30 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3034, '06/12/2020  12:42:31 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(3035, '06/12/2020  12:42:32 PM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(3036, '06/12/2020  12:42:40 PM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(3037, '06/12/2020  12:42:41 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3038, '06/12/2020  12:42:43 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3039, '06/12/2020  12:42:44 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3040, '06/12/2020  12:46:34 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3041, '06/12/2020  12:46:36 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3042, '06/12/2020  12:46:36 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3043, '06/12/2020  12:46:38 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3044, '06/12/2020  12:46:39 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3045, '06/12/2020  12:46:58 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3046, '06/12/2020  12:50:58 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3047, '06/12/2020  12:50:59 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3048, '06/12/2020  12:51:00 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3049, '06/12/2020  12:51:25 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3050, '06/12/2020  12:51:27 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3051, '06/12/2020  12:51:30 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(3052, '06/12/2020  01:51:00 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3053, '06/12/2020  01:51:05 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3054, '06/12/2020  01:51:05 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3055, '06/12/2020  01:51:09 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(3056, '06/12/2020  01:51:10 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3057, '06/12/2020  01:51:48 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3058, '06/12/2020  01:52:53 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3059, '06/12/2020  01:52:54 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(3060, '06/12/2020  01:52:55 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3061, '06/12/2020  02:07:12 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3062, '06/12/2020  02:12:52 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3063, '06/12/2020  03:06:34 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3064, '06/13/2020  02:04:43 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3065, '06/13/2020  02:07:20 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3066, '06/13/2020  02:27:29 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3067, '06/13/2020  02:28:25 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3068, '06/13/2020  02:29:14 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3069, '06/13/2020  02:38:44 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3070, '06/13/2020  02:39:40 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3071, '06/13/2020  02:39:41 AM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(3072, '06/13/2020  02:39:42 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3073, '06/13/2020  03:03:30 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3074, '06/13/2020  03:03:32 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3075, '06/13/2020  03:03:33 AM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(3076, '06/13/2020  03:03:37 AM', 'Khristine Guinto Badiana', 'Backup a Data from ', 'System Admin', 'kbadiana2416'),
(3077, '06/13/2020  03:03:40 AM', 'Khristine Guinto Badiana', 'kbadiana2416Has Logged-out', 'System Admin', 'kbadiana2416'),
(3078, '06/13/2020  03:33:53 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3079, '06/13/2020  03:33:55 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3080, '06/13/2020  03:33:56 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3081, '06/13/2020  03:48:56 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3082, '06/13/2020  03:49:03 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3083, '06/13/2020  03:49:04 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3084, '06/13/2020  03:57:49 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3085, '06/13/2020  03:57:50 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3086, '06/13/2020  03:57:51 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3087, '06/13/2020  04:01:29 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3088, '06/13/2020  04:01:30 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3089, '06/13/2020  04:01:31 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3090, '06/13/2020  04:03:13 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3091, '06/13/2020  04:03:14 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3092, '06/13/2020  04:03:15 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3093, '06/13/2020  04:04:22 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3094, '06/13/2020  04:04:23 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3095, '06/13/2020  04:04:24 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3096, '06/13/2020  04:06:50 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3097, '06/13/2020  04:06:51 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3098, '06/13/2020  04:06:52 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3099, '06/13/2020  04:07:27 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3100, '06/13/2020  04:08:31 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3101, '06/13/2020  04:08:32 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3102, '06/13/2020  04:08:33 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3103, '06/13/2020  04:12:02 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3104, '06/13/2020  04:12:29 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3105, '06/13/2020  04:16:41 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3106, '06/13/2020  05:13:23 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3107, '06/13/2020  05:13:25 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3108, '06/13/2020  05:13:25 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3109, '06/13/2020  05:16:13 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3110, '06/13/2020  05:16:14 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3111, '06/13/2020  05:16:14 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3112, '06/13/2020  05:42:59 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3113, '06/13/2020  05:43:00 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3114, '06/13/2020  05:43:00 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3115, '06/13/2020  05:43:03 AM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(3116, '06/13/2020  05:43:04 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3117, '06/13/2020  05:48:09 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3118, '06/13/2020  05:48:11 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3119, '06/13/2020  05:48:12 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3120, '06/13/2020  05:53:12 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3121, '06/13/2020  05:53:14 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3122, '06/13/2020  05:53:14 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3123, '06/13/2020  05:53:19 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3124, '06/13/2020  05:53:20 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3125, '06/13/2020  05:53:21 AM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(3126, '06/13/2020  05:53:21 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3127, '06/13/2020  05:54:44 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3128, '06/13/2020  05:54:45 AM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(3129, '06/13/2020  05:54:47 AM', 'Khristine Guinto Badiana', 'kbadiana2416Has Logged-out', 'System Admin', 'kbadiana2416'),
(3130, '06/13/2020  05:54:47 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3131, '06/13/2020  05:54:52 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3132, '06/13/2020  05:54:52 AM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(3133, '06/13/2020  05:55:03 AM', 'Khristine Guinto Badiana', 'kbadiana2416Has Logged-out', 'System Admin', 'kbadiana2416'),
(3134, '06/13/2020  05:55:08 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3135, '06/13/2020  05:55:11 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3136, '06/13/2020  05:55:13 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3137, '06/13/2020  05:55:23 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3138, '06/13/2020  06:04:05 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3139, '06/13/2020  06:05:04 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3140, '06/13/2020  06:31:30 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3141, '06/13/2020  06:33:08 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3142, '06/13/2020  06:35:12 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3143, '06/13/2020  06:36:08 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3144, '06/13/2020  02:49:26 PM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(3145, '06/13/2020  02:49:52 PM', 'Khristine Guinto Badiana', 'Addded new User Accounts', 'System Admin', 'kbadiana2416'),
(3146, '06/13/2020  02:50:34 PM', 'Khristine Guinto Badiana', 'Delete a User Account ', 'System Admin', 'kbadiana2416'),
(3147, '06/13/2020  02:51:21 PM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(3148, '06/13/2020  02:51:23 PM', 'Khristine Guinto Badiana', 'Addded new User Accounts', 'System Admin', 'kbadiana2416'),
(3149, '06/13/2020  02:51:48 PM', 'Khristine Guinto Badiana', 'kbadiana2416Has Logged-out', 'System Admin', 'kbadiana2416'),
(3150, '06/13/2020  02:52:57 PM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(3151, '06/13/2020  02:52:58 PM', 'Khristine Guinto Badiana', 'kbadiana2416Has Logged-out', 'System Admin', 'kbadiana2416'),
(3152, '06/13/2020  02:59:16 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3153, '06/13/2020  03:15:00 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3154, '06/13/2020  03:16:34 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3155, '06/13/2020  03:17:32 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3156, '06/13/2020  03:18:21 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3157, '06/13/2020  03:18:49 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3158, '06/13/2020  03:18:50 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3159, '06/13/2020  03:19:00 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3160, '06/13/2020  03:19:01 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3161, '06/13/2020  04:18:40 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3162, '06/13/2020  04:19:25 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3163, '06/13/2020  04:31:47 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3164, '06/13/2020  04:31:49 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3165, '06/13/2020  04:31:49 PM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(3166, '06/13/2020  04:32:01 PM', 'Khristine Guinto Badiana', 'kbadiana2416Has Logged-out', 'System Admin', 'kbadiana2416'),
(3167, '06/13/2020  04:56:05 PM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(3168, '06/13/2020  04:56:24 PM', 'Khristine Guinto Badiana', 'kbadiana2416Has Logged-out', 'System Admin', 'kbadiana2416'),
(3169, '06/13/2020  04:56:25 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3170, '06/13/2020  04:57:11 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3171, '06/13/2020  04:57:32 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3172, '06/13/2020  04:58:47 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3173, '06/13/2020  04:58:49 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3174, '06/13/2020  04:58:50 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3175, '06/13/2020  05:00:36 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3176, '06/13/2020  05:01:15 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3177, '06/13/2020  05:01:58 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3178, '06/13/2020  05:02:54 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3179, '06/13/2020  05:03:28 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3180, '06/13/2020  05:03:30 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3181, '06/13/2020  05:03:30 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3182, '06/13/2020  05:04:08 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3183, '06/13/2020  05:04:09 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3184, '06/13/2020  05:04:10 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3185, '06/13/2020  05:05:13 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3186, '06/13/2020  05:06:05 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3187, '06/13/2020  05:06:06 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3188, '06/13/2020  05:06:08 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3189, '06/13/2020  05:07:27 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3190, '06/13/2020  05:07:29 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3191, '06/13/2020  05:07:29 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3192, '06/13/2020  05:08:22 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3193, '06/13/2020  05:09:19 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3194, '06/13/2020  05:10:15 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3195, '06/13/2020  05:11:14 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3196, '06/13/2020  05:11:51 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3197, '06/13/2020  05:13:06 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3198, '06/13/2020  05:13:06 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3199, '06/13/2020  05:13:55 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3200, '06/13/2020  05:14:16 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3201, '06/13/2020  05:14:17 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3202, '06/13/2020  05:14:31 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3203, '06/13/2020  05:14:31 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3204, '06/13/2020  05:14:59 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3205, '06/13/2020  05:15:00 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3206, '06/13/2020  05:15:28 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(3207, '06/13/2020  05:15:30 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3208, '06/13/2020  05:15:31 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(3209, '06/13/2020  05:15:31 PM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(3210, '06/13/2020  05:15:45 PM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(3211, '06/13/2020  05:15:46 PM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(3212, '06/13/2020  05:30:42 PM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(3213, '06/13/2020  05:30:52 PM', 'Khristine Guinto Badiana', 'Addded new User Accounts', 'System Admin', 'kbadiana2416'),
(3214, '06/13/2020  05:31:07 PM', 'Khristine Guinto Badiana', 'Reset Password of p.rafael', 'System Admin', 'kbadiana2416'),
(3215, '06/13/2020  05:31:24 PM', 'Khristine Guinto Badiana', 'kbadiana2416Has Logged-out', 'System Admin', 'kbadiana2416'),
(3216, '06/13/2020  05:31:26 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3217, '06/13/2020  05:38:18 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3218, '06/13/2020  05:38:20 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3219, '06/13/2020  05:40:26 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3220, '06/13/2020  05:40:27 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3221, '06/13/2020  05:40:38 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(3222, '06/13/2020  07:37:28 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3223, '06/13/2020  07:39:24 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(3224, '06/13/2020  07:39:30 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3225, '06/13/2020  07:39:31 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3226, '06/13/2020  07:39:32 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3227, '06/13/2020  07:40:08 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3228, '06/13/2020  07:40:09 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3229, '06/13/2020  07:40:58 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(3230, '06/13/2020  08:01:38 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3231, '06/13/2020  08:01:39 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3232, '06/13/2020  08:01:40 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3233, '06/13/2020  08:14:49 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3234, '06/13/2020  08:59:17 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3235, '06/13/2020  09:00:06 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3236, '06/13/2020  09:00:07 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3237, '06/13/2020  09:00:09 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3238, '06/13/2020  09:00:09 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3239, '06/13/2020  09:00:10 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3240, '06/13/2020  09:00:10 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3241, '06/13/2020  09:03:25 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3242, '06/13/2020  09:03:31 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3243, '06/13/2020  09:03:31 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3244, '06/13/2020  09:04:42 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(3245, '06/13/2020  09:29:09 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3246, '06/13/2020  09:30:12 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3247, '06/13/2020  09:32:27 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3248, '06/13/2020  09:38:25 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3249, '06/13/2020  09:38:25 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3250, '06/13/2020  09:39:34 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(3251, '06/13/2020  09:39:35 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3252, '06/13/2020  09:39:36 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3253, '06/13/2020  09:39:36 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3254, '06/13/2020  09:41:57 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3255, '06/13/2020  09:42:26 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3256, '06/13/2020  09:42:26 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(3257, '06/13/2020  09:42:27 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3258, '06/13/2020  09:43:25 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3259, '06/13/2020  09:43:26 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3260, '06/13/2020  09:43:27 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3261, '06/13/2020  09:44:34 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3262, '06/13/2020  09:49:01 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3263, '06/13/2020  09:49:03 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3264, '06/13/2020  09:49:03 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3265, '06/13/2020  09:50:12 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3266, '06/13/2020  09:50:14 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3267, '06/13/2020  09:50:14 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3268, '06/13/2020  09:50:17 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(3269, '06/13/2020  09:50:17 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3270, '06/13/2020  09:51:09 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3271, '06/13/2020  09:51:11 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3272, '06/13/2020  09:51:12 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3273, '06/13/2020  09:51:38 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3274, '06/13/2020  09:52:14 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3275, '06/13/2020  09:55:40 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3276, '06/13/2020  09:56:15 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3277, '06/13/2020  09:58:34 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3278, '06/13/2020  09:59:13 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3279, '06/13/2020  09:59:42 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3280, '06/13/2020  10:06:14 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3281, '06/13/2020  10:07:21 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3282, '06/13/2020  10:12:13 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3283, '06/13/2020  10:13:09 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3284, '06/13/2020  10:13:09 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3285, '06/13/2020  10:13:10 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3286, '06/13/2020  10:13:12 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3287, '06/13/2020  10:13:21 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3288, '06/13/2020  10:13:22 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3289, '06/13/2020  10:13:32 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3290, '06/13/2020  10:14:25 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3291, '06/13/2020  10:18:31 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3292, '06/13/2020  10:21:14 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3293, '06/13/2020  10:23:04 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3294, '06/13/2020  10:24:36 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3295, '06/13/2020  10:26:57 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3296, '06/13/2020  10:27:11 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3297, '06/13/2020  10:29:43 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3298, '06/13/2020  10:33:24 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3299, '06/13/2020  10:34:28 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3300, '06/13/2020  10:41:20 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188');
INSERT INTO `audit_trail` (`audit_id`, `date_time`, `user`, `action`, `user_type`, `username`) VALUES
(3301, '06/13/2020  10:42:21 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3302, '06/13/2020  10:48:06 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3303, '06/13/2020  10:48:09 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3304, '06/13/2020  10:48:09 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3305, '06/13/2020  10:48:15 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3306, '06/13/2020  10:48:15 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3307, '06/13/2020  10:51:52 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3308, '06/13/2020  10:56:22 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3309, '06/13/2020  10:58:04 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3310, '06/13/2020  10:59:41 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3311, '06/13/2020  11:01:00 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3312, '06/13/2020  11:02:23 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3313, '06/13/2020  11:03:53 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3314, '06/13/2020  11:25:04 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3315, '06/13/2020  11:31:58 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3316, '06/13/2020  11:34:53 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3317, '06/13/2020  11:36:06 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3318, '06/13/2020  11:36:25 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3319, '06/13/2020  11:37:46 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3320, '06/13/2020  11:38:48 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3321, '06/13/2020  11:39:38 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3322, '06/13/2020  11:43:36 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3323, '06/13/2020  11:45:02 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3324, '06/13/2020  11:55:05 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3325, '06/13/2020  11:55:09 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3326, '06/13/2020  11:56:51 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3327, '06/13/2020  11:56:59 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3328, '06/13/2020  11:56:59 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3329, '06/13/2020  11:57:04 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(3330, '06/13/2020  11:57:05 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3331, '06/13/2020  11:57:08 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3332, '06/13/2020  11:57:09 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3333, '06/13/2020  11:57:12 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3334, '06/13/2020  11:57:12 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3335, '06/13/2020  11:58:41 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(3336, '06/13/2020  11:58:42 PM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(3337, '06/13/2020  11:58:44 PM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(3338, '06/13/2020  11:58:44 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3339, '06/14/2020  12:06:33 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3340, '06/14/2020  12:07:48 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3341, '06/14/2020  12:09:18 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3342, '06/14/2020  12:09:54 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3343, '06/14/2020  12:11:57 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3344, '06/14/2020  12:13:36 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3345, '06/14/2020  12:15:46 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3346, '06/14/2020  12:17:43 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3347, '06/14/2020  12:20:52 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3348, '06/14/2020  12:21:00 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3349, '06/14/2020  12:21:00 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3350, '06/14/2020  12:22:50 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3351, '06/14/2020  12:23:43 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3352, '06/14/2020  12:23:46 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3353, '06/14/2020  12:23:47 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3354, '06/14/2020  12:24:05 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3355, '06/14/2020  12:24:11 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3356, '06/14/2020  12:24:12 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3357, '06/14/2020  12:24:31 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3358, '06/14/2020  12:24:36 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3359, '06/14/2020  12:24:37 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3360, '06/14/2020  12:25:19 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3361, '06/14/2020  12:25:23 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3362, '06/14/2020  12:25:23 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3363, '06/14/2020  12:39:25 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3364, '06/14/2020  12:41:39 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3365, '06/14/2020  01:24:21 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3366, '06/14/2020  01:28:55 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3367, '06/14/2020  01:33:23 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3368, '06/14/2020  01:34:47 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3369, '06/14/2020  01:36:19 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3370, '06/14/2020  01:49:43 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3371, '06/14/2020  01:51:54 AM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(3372, '06/14/2020  01:56:48 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3373, '06/14/2020  02:03:16 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3374, '06/14/2020  02:04:15 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3375, '06/14/2020  02:05:15 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3376, '06/14/2020  02:06:17 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3377, '06/14/2020  02:09:17 AM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(3378, '06/14/2020  04:26:25 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3379, '06/14/2020  04:26:37 AM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(3380, '06/14/2020  04:26:39 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3381, '06/14/2020  04:26:41 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3382, '06/14/2020  04:26:41 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3383, '06/14/2020  04:27:39 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3384, '06/14/2020  04:27:40 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3385, '06/14/2020  04:28:12 AM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(3386, '06/14/2020  04:28:13 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3387, '06/14/2020  04:32:38 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3388, '06/14/2020  04:32:51 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3389, '06/14/2020  04:32:52 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3390, '06/14/2020  04:33:33 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3391, '06/14/2020  04:33:34 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3392, '06/14/2020  04:33:35 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3393, '06/14/2020  04:34:55 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3394, '06/14/2020  04:35:49 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3395, '06/14/2020  04:38:38 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3396, '06/14/2020  04:55:14 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3397, '06/14/2020  04:58:51 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3398, '06/14/2020  04:59:45 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3399, '06/14/2020  05:01:10 AM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(3400, '06/14/2020  05:01:11 AM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(3401, '06/14/2020  05:02:38 AM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(3402, '06/14/2020  05:02:41 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3403, '06/14/2020  05:03:24 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3404, '06/14/2020  05:03:26 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3405, '06/14/2020  05:03:41 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3406, '06/14/2020  05:15:43 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3407, '06/14/2020  06:18:16 AM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(3408, '06/14/2020  06:18:28 AM', 'Khristine Guinto Badiana', 'Backup a Data from ', 'System Admin', 'kbadiana2416'),
(3409, '06/14/2020  06:18:32 AM', 'Khristine Guinto Badiana', 'kbadiana2416Has Logged-out', 'System Admin', 'kbadiana2416'),
(3410, '06/14/2020  06:18:33 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3411, '06/14/2020  06:18:47 AM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(3412, '06/14/2020  07:01:01 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3413, '06/14/2020  07:01:25 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3414, '06/14/2020  07:01:25 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3415, '06/14/2020  07:02:13 AM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(3416, '06/14/2020  01:40:14 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3417, '06/14/2020  01:42:02 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(3418, '06/14/2020  01:42:03 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3419, '06/14/2020  01:42:07 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(3420, '06/14/2020  01:42:08 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3421, '06/14/2020  01:43:48 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3422, '06/14/2020  02:08:48 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3423, '06/14/2020  02:09:35 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(3424, '06/14/2020  03:52:07 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3425, '06/14/2020  03:52:56 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(3426, '06/14/2020  03:52:57 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3427, '06/14/2020  03:53:02 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3428, '06/14/2020  03:53:09 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3429, '06/14/2020  03:54:01 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(3430, '06/14/2020  03:54:01 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3431, '06/14/2020  03:54:03 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(3432, '06/14/2020  03:54:03 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3433, '06/14/2020  03:59:33 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3434, '06/14/2020  04:00:08 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3435, '06/14/2020  04:00:09 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(3436, '06/14/2020  04:00:11 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3437, '06/14/2020  04:00:38 PM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(3438, '06/14/2020  04:01:41 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3439, '06/14/2020  04:01:44 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(3440, '06/14/2020  04:01:45 PM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(3441, '06/14/2020  04:04:02 PM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(3442, '06/14/2020  04:04:51 PM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(3443, '06/14/2020  04:30:30 PM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(3444, '06/14/2020  04:30:44 PM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(3445, '06/14/2020  04:30:54 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3446, '06/14/2020  04:31:02 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3447, '06/14/2020  04:42:53 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3448, '06/14/2020  04:43:46 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(3449, '06/14/2020  04:43:47 PM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(3450, '06/14/2020  04:43:57 PM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(3451, '06/14/2020  04:43:58 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3452, '06/14/2020  04:44:03 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3453, '06/14/2020  04:44:04 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3454, '06/14/2020  04:46:35 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3455, '06/14/2020  04:46:37 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3456, '06/14/2020  04:46:37 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3457, '06/14/2020  04:48:47 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3458, '06/14/2020  04:50:41 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(3459, '06/14/2020  04:50:42 PM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(3460, '06/14/2020  04:50:43 PM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(3461, '06/14/2020  04:50:43 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3462, '06/14/2020  04:50:44 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3463, '06/14/2020  04:50:45 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3464, '06/14/2020  04:50:51 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3465, '06/14/2020  04:50:51 PM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(3466, '06/14/2020  04:50:57 PM', 'Khristine Guinto Badiana', 'kbadiana2416Has Logged-out', 'System Admin', 'kbadiana2416'),
(3467, '06/14/2020  04:50:58 PM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(3468, '06/14/2020  04:51:49 PM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(3469, '06/14/2020  04:51:50 PM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(3470, '06/14/2020  04:52:03 PM', 'Khristine Guinto Badiana', 'kbadiana2416Has Logged-out', 'System Admin', 'kbadiana2416'),
(3471, '06/14/2020  04:52:04 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3472, '06/14/2020  04:54:44 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3473, '06/14/2020  04:58:00 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3474, '06/14/2020  04:58:03 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3475, '06/14/2020  04:58:04 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3476, '06/14/2020  04:59:11 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3477, '06/14/2020  04:59:13 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3478, '06/14/2020  04:59:14 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3479, '06/14/2020  05:00:52 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3480, '06/14/2020  05:00:56 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3481, '06/14/2020  05:00:56 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3482, '06/14/2020  05:02:46 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3483, '06/14/2020  05:03:34 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3484, '06/14/2020  05:03:37 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(3485, '06/14/2020  05:03:37 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3486, '06/14/2020  05:03:40 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3487, '06/14/2020  05:03:41 PM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3488, '06/14/2020  05:03:45 PM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(3489, '06/14/2020  05:03:48 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3490, '06/14/2020  05:04:07 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3491, '06/14/2020  05:04:10 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3492, '06/14/2020  05:04:12 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3493, '06/14/2020  05:04:13 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3494, '06/14/2020  05:08:16 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3495, '06/14/2020  05:09:28 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3496, '06/14/2020  05:09:30 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3497, '06/14/2020  05:09:31 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3498, '06/14/2020  05:11:04 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3499, '06/14/2020  05:11:05 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3500, '06/14/2020  05:11:06 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3501, '06/14/2020  05:13:38 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3502, '06/14/2020  05:13:39 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3503, '06/14/2020  05:13:51 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3504, '06/14/2020  05:15:31 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3505, '06/14/2020  05:17:53 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3506, '06/14/2020  05:20:07 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3507, '06/14/2020  05:20:08 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3508, '06/14/2020  05:20:09 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3509, '06/14/2020  05:21:51 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3510, '06/14/2020  05:29:05 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3511, '06/14/2020  05:31:07 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3512, '06/14/2020  05:32:07 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3513, '06/14/2020  09:02:20 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3514, '06/14/2020  09:07:01 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3515, '06/14/2020  09:11:55 PM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(3516, '06/14/2020  09:12:00 PM', 'Khristine Guinto Badiana', 'Addded new User Accounts', 'System Admin', 'kbadiana2416'),
(3517, '06/14/2020  09:12:15 PM', 'Khristine Guinto Badiana', 'kbadiana2416Has Logged-out', 'System Admin', 'kbadiana2416'),
(3518, '06/14/2020  09:12:16 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3519, '06/14/2020  09:12:46 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3520, '06/14/2020  09:45:23 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3521, '06/14/2020  09:45:59 PM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3522, '06/14/2020  09:47:04 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3523, '06/14/2020  09:47:05 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3524, '06/14/2020  09:47:06 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3525, '06/14/2020  10:04:39 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3526, '06/14/2020  10:04:40 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3527, '06/14/2020  10:04:41 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3528, '06/14/2020  11:21:00 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3529, '06/14/2020  11:21:02 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3530, '06/14/2020  11:21:02 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3531, '06/14/2020  11:24:29 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3532, '06/14/2020  11:25:09 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3533, '06/14/2020  11:25:11 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3534, '06/14/2020  11:25:11 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3535, '06/14/2020  11:27:17 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3536, '06/14/2020  11:27:19 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3537, '06/14/2020  11:27:20 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3538, '06/14/2020  11:32:50 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3539, '06/14/2020  11:32:53 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3540, '06/14/2020  11:32:55 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3541, '06/14/2020  11:40:15 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3542, '06/14/2020  11:40:16 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3543, '06/14/2020  11:40:17 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3544, '06/14/2020  11:41:45 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3545, '06/14/2020  11:41:46 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3546, '06/14/2020  11:41:47 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3547, '06/14/2020  11:43:35 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3548, '06/14/2020  11:44:17 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3549, '06/14/2020  11:45:15 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3550, '06/14/2020  11:47:55 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3551, '06/14/2020  11:48:51 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3552, '06/14/2020  11:48:52 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3553, '06/14/2020  11:48:53 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3554, '06/14/2020  11:52:35 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3555, '06/14/2020  11:54:20 PM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3556, '06/14/2020  11:54:21 PM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3557, '06/14/2020  11:54:22 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3558, '06/14/2020  11:58:32 PM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3559, '06/15/2020  12:00:09 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3560, '06/15/2020  12:02:57 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3561, '06/15/2020  12:06:04 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3562, '06/15/2020  12:11:27 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3563, '06/15/2020  12:11:29 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3564, '06/15/2020  12:11:29 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3565, '06/15/2020  12:14:19 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3566, '06/15/2020  12:32:37 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3567, '06/15/2020  12:32:39 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3568, '06/15/2020  12:32:39 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3569, '06/15/2020  12:37:36 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3570, '06/15/2020  12:42:54 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3571, '06/15/2020  12:42:56 AM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(3572, '06/15/2020  12:43:12 AM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(3573, '06/15/2020  12:43:29 AM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(3574, '06/15/2020  12:43:37 AM', 'Khristine Guinto Badiana', 'kbadiana2416Has Logged-out', 'System Admin', 'kbadiana2416'),
(3575, '06/15/2020  12:43:38 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3576, '06/15/2020  12:43:39 AM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(3577, '06/15/2020  12:43:40 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3578, '06/15/2020  12:43:52 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3579, '06/15/2020  12:43:53 AM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(3580, '06/15/2020  12:43:55 AM', 'Khristine Guinto Badiana', 'Addded new User Accounts', 'System Admin', 'kbadiana2416'),
(3581, '06/15/2020  12:44:03 AM', 'Khristine Guinto Badiana', 'kbadiana2416Has Logged-out', 'System Admin', 'kbadiana2416'),
(3582, '06/15/2020  12:44:04 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3583, '06/15/2020  12:45:47 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3584, '06/15/2020  12:45:56 AM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(3585, '06/15/2020  12:46:00 AM', 'Khristine Guinto Badiana', 'Reset Password of b.rafael', 'System Admin', 'kbadiana2416'),
(3586, '06/15/2020  12:46:21 AM', 'Khristine Guinto Badiana', 'kbadiana2416Has Logged-out', 'System Admin', 'kbadiana2416'),
(3587, '06/15/2020  12:46:23 AM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(3588, '06/15/2020  12:46:35 AM', 'Khristine Guinto Badiana', 'kbadiana2416Has Logged-out', 'System Admin', 'kbadiana2416'),
(3589, '06/15/2020  12:46:44 AM', 'sdasd asd asd', 'User has been Login', 'Teacher', 'a.sdasd'),
(3590, '06/15/2020  12:59:36 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3591, '06/15/2020  01:11:38 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3592, '06/15/2020  01:11:44 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3593, '06/15/2020  01:12:03 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3594, '06/15/2020  01:12:04 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3595, '06/15/2020  01:12:05 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3596, '06/15/2020  01:12:46 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3597, '06/15/2020  01:12:46 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3598, '06/15/2020  01:13:35 AM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(3599, '06/15/2020  01:13:35 AM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(3600, '06/15/2020  01:13:36 AM', 'Khristine Guinto Badiana', 'kbadiana2416Has Logged-out', 'System Admin', 'kbadiana2416'),
(3601, '06/15/2020  01:13:37 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3602, '06/15/2020  01:14:09 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3603, '06/15/2020  01:14:10 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3604, '06/15/2020  01:14:14 AM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(3605, '06/15/2020  01:14:15 AM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(3606, '06/15/2020  01:14:18 AM', 'Khristine Guinto Badiana', 'kbadiana2416Has Logged-out', 'System Admin', 'kbadiana2416'),
(3607, '06/15/2020  01:14:18 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3608, '06/15/2020  01:14:21 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3609, '06/15/2020  01:14:22 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3610, '06/15/2020  01:14:51 AM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(3611, '06/15/2020  01:14:53 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3612, '06/15/2020  01:15:32 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3613, '06/15/2020  01:25:08 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3614, '06/15/2020  01:43:38 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3615, '06/15/2020  01:43:40 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3616, '06/15/2020  01:43:41 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3617, '06/15/2020  01:47:44 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3618, '06/15/2020  01:48:03 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3619, '06/15/2020  01:48:04 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3620, '06/15/2020  02:40:29 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3621, '06/15/2020  02:40:32 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3622, '06/15/2020  02:40:33 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3623, '06/15/2020  02:40:34 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3624, '06/15/2020  02:40:35 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3625, '06/15/2020  02:41:25 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3626, '06/15/2020  02:41:26 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3627, '06/15/2020  02:41:42 AM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(3628, '06/15/2020  02:41:43 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3629, '06/15/2020  02:42:40 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3630, '06/15/2020  02:42:43 AM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(3631, '06/15/2020  02:42:43 AM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(3632, '06/15/2020  02:42:44 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3633, '06/15/2020  02:42:47 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3634, '06/15/2020  02:42:49 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3635, '06/15/2020  02:42:52 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3636, '06/15/2020  02:42:53 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3637, '06/15/2020  02:43:52 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3638, '06/15/2020  02:44:18 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3639, '06/15/2020  02:44:31 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3640, '06/15/2020  02:45:47 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3641, '06/15/2020  02:45:53 AM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(3642, '06/15/2020  02:45:54 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3643, '06/15/2020  02:45:56 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3644, '06/15/2020  02:45:57 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3645, '06/15/2020  02:52:30 AM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(3646, '06/15/2020  02:52:31 AM', 'Khristine Guinto Badiana', 'kbadiana2416Has Logged-out', 'System Admin', 'kbadiana2416'),
(3647, '06/15/2020  02:52:32 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3648, '06/15/2020  02:52:33 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3649, '06/15/2020  02:52:34 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3650, '06/15/2020  02:52:35 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3651, '06/15/2020  02:52:36 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3652, '06/15/2020  02:52:36 AM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(3653, '06/15/2020  02:52:37 AM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(3654, '06/15/2020  02:52:38 AM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(3655, '06/15/2020  03:14:32 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3656, '06/15/2020  03:21:07 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3657, '06/15/2020  03:22:00 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3658, '06/15/2020  03:23:03 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3659, '06/15/2020  03:23:05 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3660, '06/15/2020  03:23:05 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3661, '06/15/2020  03:26:03 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3662, '06/15/2020  03:58:41 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3663, '06/15/2020  04:02:50 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3664, '06/15/2020  04:02:51 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3665, '06/15/2020  04:02:55 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3666, '06/15/2020  04:02:56 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3667, '06/15/2020  04:04:08 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3668, '06/15/2020  04:04:09 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3669, '06/15/2020  04:04:54 AM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(3670, '06/15/2020  04:04:55 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3671, '06/15/2020  04:05:31 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3672, '06/15/2020  04:05:32 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3673, '06/15/2020  04:05:35 AM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(3674, '06/15/2020  04:05:36 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3675, '06/15/2020  04:05:39 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3676, '06/15/2020  04:05:40 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3677, '06/15/2020  04:05:45 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3678, '06/15/2020  04:05:46 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3679, '06/15/2020  04:05:48 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3680, '06/15/2020  04:05:50 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3681, '06/15/2020  04:05:53 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3682, '06/15/2020  04:05:54 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3683, '06/15/2020  04:05:57 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3684, '06/15/2020  04:05:57 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3685, '06/15/2020  04:11:54 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3686, '06/15/2020  04:15:05 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3687, '06/15/2020  04:15:09 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3688, '06/15/2020  04:15:10 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3689, '06/15/2020  04:16:25 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3690, '06/15/2020  04:16:28 AM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(3691, '06/15/2020  04:16:34 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3692, '06/15/2020  04:17:34 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3693, '06/15/2020  04:25:03 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3694, '06/15/2020  04:25:09 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3695, '06/15/2020  04:25:11 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3696, '06/15/2020  04:29:10 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3697, '06/15/2020  04:31:51 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3698, '06/15/2020  04:31:57 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3699, '06/15/2020  04:31:57 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3700, '06/15/2020  04:33:45 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3701, '06/15/2020  04:33:48 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3702, '06/15/2020  04:33:49 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3703, '06/15/2020  04:34:02 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3704, '06/15/2020  04:34:03 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3705, '06/15/2020  04:34:37 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3706, '06/15/2020  04:34:39 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3707, '06/15/2020  04:34:44 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3708, '06/15/2020  04:34:45 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3709, '06/15/2020  04:37:11 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3710, '06/15/2020  04:37:12 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3711, '06/15/2020  04:43:30 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3712, '06/15/2020  04:43:33 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3713, '06/15/2020  04:43:34 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3714, '06/15/2020  04:44:50 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3715, '06/15/2020  04:44:52 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3716, '06/15/2020  04:44:53 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3717, '06/15/2020  04:44:56 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3718, '06/15/2020  04:44:57 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3719, '06/15/2020  04:46:42 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3720, '06/15/2020  04:46:44 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3721, '06/15/2020  04:46:45 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3722, '06/15/2020  04:46:46 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3723, '06/15/2020  04:46:47 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3724, '06/15/2020  04:48:54 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3725, '06/15/2020  04:51:02 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3726, '06/15/2020  04:52:58 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3727, '06/15/2020  05:00:25 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3728, '06/15/2020  05:02:38 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3729, '06/15/2020  05:06:46 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3730, '06/15/2020  05:08:25 AM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(3731, '06/15/2020  05:08:27 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3732, '06/15/2020  05:09:19 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3733, '06/15/2020  05:09:20 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3734, '06/15/2020  05:17:33 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3735, '06/15/2020  05:17:34 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3736, '06/15/2020  05:17:35 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3737, '06/15/2020  05:17:36 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3738, '06/15/2020  05:17:36 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3739, '06/15/2020  05:18:57 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3740, '06/15/2020  05:19:53 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3741, '06/15/2020  05:31:25 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028');
INSERT INTO `audit_trail` (`audit_id`, `date_time`, `user`, `action`, `user_type`, `username`) VALUES
(3742, '06/15/2020  05:33:21 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3743, '06/15/2020  05:40:18 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3744, '06/15/2020  05:46:22 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3745, '06/15/2020  05:52:02 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3746, '06/15/2020  05:52:06 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3747, '06/15/2020  05:52:06 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3748, '06/15/2020  05:52:11 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3749, '06/15/2020  05:52:11 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3750, '06/15/2020  05:56:20 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3751, '06/15/2020  06:00:20 AM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(3752, '06/15/2020  06:00:23 AM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(3753, '06/15/2020  06:00:24 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3754, '06/15/2020  06:00:32 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3755, '06/15/2020  06:00:33 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3756, '06/15/2020  06:02:18 AM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(3757, '06/15/2020  06:02:20 AM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(3758, '06/15/2020  06:02:21 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3759, '06/15/2020  06:12:56 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3760, '06/15/2020  06:13:30 AM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(3761, '06/15/2020  06:13:32 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3762, '06/15/2020  06:13:33 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3763, '06/15/2020  06:13:34 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3764, '06/15/2020  06:14:16 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3765, '06/15/2020  06:14:17 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3766, '06/15/2020  06:15:39 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3767, '06/15/2020  06:16:14 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3768, '06/15/2020  06:16:15 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3769, '06/15/2020  06:16:56 AM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(3770, '06/15/2020  06:16:56 AM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(3771, '06/15/2020  06:16:59 AM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(3772, '06/15/2020  06:17:01 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3773, '06/15/2020  06:17:04 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3774, '06/15/2020  06:17:04 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3775, '06/15/2020  06:17:12 AM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(3776, '06/15/2020  06:17:13 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3777, '06/15/2020  06:17:50 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3778, '06/15/2020  06:17:50 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3779, '06/15/2020  06:27:18 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3780, '06/15/2020  06:27:25 AM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(3781, '06/15/2020  06:27:26 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3782, '06/15/2020  06:28:08 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3783, '06/15/2020  06:28:09 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3784, '06/15/2020  06:30:02 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3785, '06/15/2020  06:36:37 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3786, '06/15/2020  06:36:38 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3787, '06/15/2020  06:36:39 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3788, '06/15/2020  06:39:15 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3789, '06/15/2020  06:39:19 AM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(3790, '06/15/2020  06:39:20 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3791, '06/15/2020  06:39:22 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3792, '06/15/2020  06:39:23 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3793, '06/15/2020  06:47:45 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3794, '06/15/2020  06:47:46 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3795, '06/15/2020  06:47:47 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3796, '06/15/2020  06:48:13 AM', 'Marisol Amaro Jadlocon', 'mjadlocon6188Has Logged-out', 'Registrar', 'mjadlocon6188'),
(3797, '06/15/2020  06:48:15 AM', 'Missly Ann Manabat Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(3798, '06/15/2020  06:48:27 AM', 'Missly Ann Manabat Davalos', 'mdavalos4028Has Logged-out', 'Cashier', 'mdavalos4028'),
(3799, '06/15/2020  06:48:28 AM', 'Sean  Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(3800, '06/15/2020  06:49:16 AM', 'Sean  Yang', 'Syang0900Has Logged-out', 'Teacher', 'Syang0900'),
(3801, '06/15/2020  06:52:50 AM', 'Marisol Amaro Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(3802, '06/15/2020  06:53:34 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3803, '06/15/2020  06:55:55 AM', 'Paula Crisostomo Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(3804, '06/15/2020  06:56:03 AM', 'Paula Crisostomo Uy', 'puy4120Has Logged-out', 'Enrollment Admin', 'puy4120'),
(3805, '06/15/2020  06:56:04 AM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'kbadiana2416');

-- --------------------------------------------------------

--
-- Table structure for table `classroom`
--

CREATE TABLE `classroom` (
  `classroom_id` int(11) NOT NULL,
  `classroom_type` int(11) NOT NULL,
  `classroom_no` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `classroom`
--

INSERT INTO `classroom` (`classroom_id`, `classroom_type`, `classroom_no`) VALUES
(20, 9, 1);

-- --------------------------------------------------------

--
-- Table structure for table `classroom_type`
--

CREATE TABLE `classroom_type` (
  `classroom_type_id` int(11) NOT NULL,
  `name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `classroom_type`
--

INSERT INTO `classroom_type` (`classroom_type_id`, `name`) VALUES
(9, 'Normal Room');

-- --------------------------------------------------------

--
-- Table structure for table `enrollment_schedule`
--

CREATE TABLE `enrollment_schedule` (
  `enrollment_sched_id` int(11) NOT NULL,
  `start_date` text NOT NULL,
  `end_date` text NOT NULL,
  `is_open` int(11) NOT NULL,
  `SY_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `enrollment_schedule`
--

INSERT INTO `enrollment_schedule` (`enrollment_sched_id`, `start_date`, `end_date`, `is_open`, `SY_id`) VALUES
(8, '23/01/2020', '30/06/2020', 1, 1),
(10, '15/06/2020', '30/06/2020', 0, 8);

-- --------------------------------------------------------

--
-- Table structure for table `grade_level`
--

CREATE TABLE `grade_level` (
  `gradelvl_id` int(11) NOT NULL,
  `grade_type` text NOT NULL,
  `grade_level` text NOT NULL,
  `SY_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `misc_fee`
--

CREATE TABLE `misc_fee` (
  `miscfee_id` int(11) NOT NULL,
  `details` text NOT NULL,
  `price` int(11) NOT NULL,
  `grade_level` text NOT NULL,
  `SY_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `orno`
--

CREATE TABLE `orno` (
  `orNo` int(11) NOT NULL,
  `oror` varchar(100) NOT NULL,
  `sno` varchar(255) NOT NULL,
  `amount` float NOT NULL,
  `date_pay` varchar(100) NOT NULL,
  `syid` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `sched_section`
--

CREATE TABLE `sched_section` (
  `ss_id` int(11) NOT NULL,
  `timestamp_id` int(11) NOT NULL,
  `subject_id` int(11) NOT NULL,
  `teacher_ID` int(11) NOT NULL,
  `classroom_id` int(11) NOT NULL,
  `sect_id` int(11) NOT NULL,
  `SY_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `school_requirements`
--

CREATE TABLE `school_requirements` (
  `req_id` int(11) NOT NULL,
  `type_of_student` text NOT NULL,
  `requirement_name` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `school_requirements`
--

INSERT INTO `school_requirements` (`req_id`, `type_of_student`, `requirement_name`) VALUES
(20, 'New Student', 'FORM 138'),
(21, 'Old Student', 'PaySlip');

-- --------------------------------------------------------

--
-- Table structure for table `school_year`
--

CREATE TABLE `school_year` (
  `id` int(11) NOT NULL,
  `school_year` varchar(9) NOT NULL,
  `sy_status` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `school_year`
--

INSERT INTO `school_year` (`id`, `school_year`, `sy_status`) VALUES
(1, '2018-2019', 'activate'),
(8, '2020-2021', 'deactivate');

-- --------------------------------------------------------

--
-- Table structure for table `sections`
--

CREATE TABLE `sections` (
  `sect_id` int(11) NOT NULL,
  `grade_level` text NOT NULL,
  `teacher_ID` int(11) NOT NULL,
  `section_name` text NOT NULL,
  `limit_capacity` int(11) DEFAULT NULL,
  `SY_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `specialization`
--

CREATE TABLE `specialization` (
  `teacher_ID` int(11) NOT NULL,
  `acc_id` varchar(20) NOT NULL,
  `subject_id` int(11) NOT NULL,
  `teaching_type` varchar(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `studentenrolledinfo`
--

CREATE TABLE `studentenrolledinfo` (
  `studentenrolled_id` int(11) NOT NULL,
  `sno` varchar(255) NOT NULL,
  `grade_level` varchar(50) NOT NULL,
  `sect_id` int(11) NOT NULL,
  `is_Enrolled` int(11) NOT NULL,
  `sy_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `students_requirement`
--

CREATE TABLE `students_requirement` (
  `student_req_id` int(11) NOT NULL,
  `student_no` varchar(255) NOT NULL,
  `req_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `student_balance`
--

CREATE TABLE `student_balance` (
  `balance_id` int(11) NOT NULL,
  `sno` varchar(255) NOT NULL,
  `balance` double NOT NULL,
  `totalPayment` double NOT NULL,
  `modeofpayment` varchar(15) NOT NULL,
  `need_to_pay` double NOT NULL,
  `disc` float NOT NULL,
  `upon_pay` float NOT NULL,
  `SY_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `student_detail`
--

CREATE TABLE `student_detail` (
  `student_id` int(11) NOT NULL,
  `sno` varchar(255) NOT NULL,
  `firstname` varchar(20) NOT NULL,
  `lastname` varchar(20) NOT NULL,
  `middlename` varchar(20) NOT NULL,
  `gender` varchar(10) NOT NULL,
  `age` int(11) NOT NULL,
  `birthdate` varchar(10) NOT NULL,
  `pob` varchar(10) NOT NULL,
  `contact_no` varchar(15) DEFAULT NULL,
  `nationality` varchar(10) NOT NULL,
  `religion` varchar(10) NOT NULL,
  `address` text NOT NULL,
  `studentype` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `student_family_details`
--

CREATE TABLE `student_family_details` (
  `student_fam_id` int(11) NOT NULL,
  `sno` varchar(255) NOT NULL,
  `father_name` varchar(30) DEFAULT NULL,
  `father_no` varchar(10) DEFAULT NULL,
  `father_occu` varchar(10) DEFAULT NULL,
  `father_comp_name` varchar(15) DEFAULT 'NULL',
  `father_Ctel_no` varchar(15) DEFAULT 'NULL',
  `father_office_address` text DEFAULT NULL,
  `mother_name` varchar(30) DEFAULT 'NULL',
  `mother_no` varchar(10) DEFAULT 'NULL',
  `mother_occu` varchar(10) DEFAULT 'NULL',
  `mother_comp_name` text NOT NULL,
  `mother_Ctel_no` varchar(15) DEFAULT NULL,
  `mother_office_add` text DEFAULT NULL,
  `guardian_name` varchar(30) DEFAULT NULL,
  `guardian_add` text DEFAULT NULL,
  `guardian_relation` varchar(10) DEFAULT NULL,
  `guardian_no` varchar(15) DEFAULT NULL,
  `parent_status` varchar(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `student_grades`
--

CREATE TABLE `student_grades` (
  `studentgrade_id` int(11) NOT NULL,
  `sno` varchar(255) NOT NULL,
  `grade_first` double NOT NULL,
  `grade_second` double NOT NULL,
  `grade_third` double NOT NULL,
  `grade_fourth` decimal(10,0) NOT NULL,
  `avg` double NOT NULL,
  `subject_id` int(11) NOT NULL,
  `sect_id` int(11) NOT NULL,
  `teacher_ID` int(11) NOT NULL,
  `SY_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `student_reservepay`
--

CREATE TABLE `student_reservepay` (
  `reservepay` int(11) NOT NULL,
  `sno` varchar(255) NOT NULL,
  `payment` float NOT NULL,
  `syid` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `stud_history_details`
--

CREATE TABLE `stud_history_details` (
  `stud_his_id` int(11) NOT NULL,
  `sno` varchar(255) NOT NULL,
  `nameschool` text NOT NULL,
  `past_school_add` text NOT NULL,
  `past_level` varchar(10) NOT NULL,
  `year_attended` varchar(10) NOT NULL,
  `isCompletedVacine` varchar(11) NOT NULL,
  `vacination_details` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `subjects`
--

CREATE TABLE `subjects` (
  `subject_id` int(11) NOT NULL,
  `grade_level` text NOT NULL,
  `subject_name` text NOT NULL,
  `subject_type_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `subjectype`
--

CREATE TABLE `subjectype` (
  `sub_type_id` int(11) NOT NULL,
  `subject_type` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `timestamp`
--

CREATE TABLE `timestamp` (
  `timestamp_id` int(11) NOT NULL,
  `start_time` time NOT NULL,
  `end_time` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `timestamp`
--

INSERT INTO `timestamp` (`timestamp_id`, `start_time`, `end_time`) VALUES
(31, '07:00:00', '08:00:00'),
(32, '08:00:00', '09:00:00');

-- --------------------------------------------------------

--
-- Table structure for table `tuition_fee`
--

CREATE TABLE `tuition_fee` (
  `tf_id` int(11) NOT NULL,
  `grade_level` text NOT NULL,
  `tuition_fee` double NOT NULL,
  `mode_of_payment` text NOT NULL,
  `SY_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `useraccounts`
--

CREATE TABLE `useraccounts` (
  `acc_id` varchar(255) NOT NULL,
  `Firstname` text NOT NULL,
  `Middlename` text NOT NULL,
  `Lastname` text NOT NULL,
  `Username` text NOT NULL,
  `Password` text NOT NULL,
  `Role` text NOT NULL,
  `Status` text NOT NULL,
  `create_at` varchar(50) NOT NULL,
  `isPaswordChanged` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `useraccounts`
--

INSERT INTO `useraccounts` (`acc_id`, `Firstname`, `Middlename`, `Lastname`, `Username`, `Password`, `Role`, `Status`, `create_at`, `isPaswordChanged`) VALUES
('CST-2003-0850', 'Missly Ann', 'Manabat', 'Davalos', 'mdavalos4028', '431187', 'Cashier', 'Offline', '2019-10-29 10:01:44', 1),
('CST-2003-0909', 'Sean', '', 'Yang', 'Syang0900', '123456', 'Teacher', 'Offline', '', 1),
('CST-2003-2004', 'Paula', 'Crisostomo', 'Uy', 'puy4120', '1234567', 'Enrollment Admin', 'Offline', '2019-10-29 10:01:56', 1),
('CST-2003-8968', 'Khristine', 'Guinto', 'Badiana', 'kbadiana2416', '12345678', 'System Admin', 'Online', '2019-10-29 09:59:10', 1),
('CST-2003-9768', 'Marisol', 'Amaro', 'Jadlocon', 'mjadlocon6188', '12345678', 'Registrar', 'Online', '2019-10-29 10:01:25', 1),
('CST-2013-3020', 'Ashley', 'tapic', 'Sombilon', 'ASombilon', '123456', 'System Admin', 'Offline', 'February/21/2020  12:30:34 PM', 1),
('CST-2013-5817', 'Rex Harvey', 'Runa', 'Luna', 'Rex14', '12345', 'Registrar', 'Offline', 'February/21/2020  02:50:41 PM', 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `audit_trail`
--
ALTER TABLE `audit_trail`
  ADD PRIMARY KEY (`audit_id`);

--
-- Indexes for table `classroom`
--
ALTER TABLE `classroom`
  ADD PRIMARY KEY (`classroom_id`),
  ADD KEY `classroom_type` (`classroom_type`);

--
-- Indexes for table `classroom_type`
--
ALTER TABLE `classroom_type`
  ADD PRIMARY KEY (`classroom_type_id`);

--
-- Indexes for table `enrollment_schedule`
--
ALTER TABLE `enrollment_schedule`
  ADD PRIMARY KEY (`enrollment_sched_id`);

--
-- Indexes for table `grade_level`
--
ALTER TABLE `grade_level`
  ADD PRIMARY KEY (`gradelvl_id`);

--
-- Indexes for table `misc_fee`
--
ALTER TABLE `misc_fee`
  ADD PRIMARY KEY (`miscfee_id`);

--
-- Indexes for table `orno`
--
ALTER TABLE `orno`
  ADD PRIMARY KEY (`orNo`),
  ADD KEY `deleteorsno` (`sno`);

--
-- Indexes for table `sched_section`
--
ALTER TABLE `sched_section`
  ADD PRIMARY KEY (`ss_id`),
  ADD KEY `delete` (`teacher_ID`),
  ADD KEY `delete2` (`classroom_id`),
  ADD KEY `de` (`timestamp_id`),
  ADD KEY `asd` (`subject_id`),
  ADD KEY `des` (`sect_id`);

--
-- Indexes for table `school_requirements`
--
ALTER TABLE `school_requirements`
  ADD PRIMARY KEY (`req_id`);

--
-- Indexes for table `school_year`
--
ALTER TABLE `school_year`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `sections`
--
ALTER TABLE `sections`
  ADD PRIMARY KEY (`sect_id`),
  ADD KEY `deletesec` (`teacher_ID`);

--
-- Indexes for table `specialization`
--
ALTER TABLE `specialization`
  ADD PRIMARY KEY (`teacher_ID`),
  ADD KEY `deletespec` (`acc_id`);

--
-- Indexes for table `studentenrolledinfo`
--
ALTER TABLE `studentenrolledinfo`
  ADD PRIMARY KEY (`studentenrolled_id`),
  ADD KEY `deletesno` (`sno`),
  ADD KEY `deletesectss` (`sect_id`);

--
-- Indexes for table `students_requirement`
--
ALTER TABLE `students_requirement`
  ADD PRIMARY KEY (`student_req_id`),
  ADD KEY `sd` (`student_no`),
  ADD KEY `studreqidsde` (`req_id`);

--
-- Indexes for table `student_balance`
--
ALTER TABLE `student_balance`
  ADD PRIMARY KEY (`balance_id`),
  ADD KEY `deletebalance` (`sno`);

--
-- Indexes for table `student_detail`
--
ALTER TABLE `student_detail`
  ADD PRIMARY KEY (`student_id`),
  ADD UNIQUE KEY `sno_2` (`sno`),
  ADD KEY `sno` (`sno`);

--
-- Indexes for table `student_family_details`
--
ALTER TABLE `student_family_details`
  ADD PRIMARY KEY (`student_fam_id`),
  ADD KEY `deletefam` (`sno`);

--
-- Indexes for table `student_grades`
--
ALTER TABLE `student_grades`
  ADD PRIMARY KEY (`studentgrade_id`),
  ADD KEY `deletegrades` (`sno`),
  ADD KEY `deleteteacher` (`teacher_ID`),
  ADD KEY `deletesect` (`sect_id`);

--
-- Indexes for table `student_reservepay`
--
ALTER TABLE `student_reservepay`
  ADD PRIMARY KEY (`reservepay`),
  ADD KEY `deleterserve` (`sno`);

--
-- Indexes for table `stud_history_details`
--
ALTER TABLE `stud_history_details`
  ADD PRIMARY KEY (`stud_his_id`),
  ADD KEY `deletehis` (`sno`);

--
-- Indexes for table `subjects`
--
ALTER TABLE `subjects`
  ADD PRIMARY KEY (`subject_id`),
  ADD KEY `cascadetypesub` (`subject_type_id`);

--
-- Indexes for table `subjectype`
--
ALTER TABLE `subjectype`
  ADD PRIMARY KEY (`sub_type_id`);

--
-- Indexes for table `timestamp`
--
ALTER TABLE `timestamp`
  ADD PRIMARY KEY (`timestamp_id`);

--
-- Indexes for table `tuition_fee`
--
ALTER TABLE `tuition_fee`
  ADD PRIMARY KEY (`tf_id`);

--
-- Indexes for table `useraccounts`
--
ALTER TABLE `useraccounts`
  ADD PRIMARY KEY (`acc_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `audit_trail`
--
ALTER TABLE `audit_trail`
  MODIFY `audit_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3806;

--
-- AUTO_INCREMENT for table `classroom`
--
ALTER TABLE `classroom`
  MODIFY `classroom_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT for table `classroom_type`
--
ALTER TABLE `classroom_type`
  MODIFY `classroom_type_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `enrollment_schedule`
--
ALTER TABLE `enrollment_schedule`
  MODIFY `enrollment_sched_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `grade_level`
--
ALTER TABLE `grade_level`
  MODIFY `gradelvl_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `misc_fee`
--
ALTER TABLE `misc_fee`
  MODIFY `miscfee_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT for table `orno`
--
ALTER TABLE `orno`
  MODIFY `orNo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=115;

--
-- AUTO_INCREMENT for table `sched_section`
--
ALTER TABLE `sched_section`
  MODIFY `ss_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=48;

--
-- AUTO_INCREMENT for table `school_requirements`
--
ALTER TABLE `school_requirements`
  MODIFY `req_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT for table `school_year`
--
ALTER TABLE `school_year`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `sections`
--
ALTER TABLE `sections`
  MODIFY `sect_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;

--
-- AUTO_INCREMENT for table `specialization`
--
ALTER TABLE `specialization`
  MODIFY `teacher_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- AUTO_INCREMENT for table `studentenrolledinfo`
--
ALTER TABLE `studentenrolledinfo`
  MODIFY `studentenrolled_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=51;

--
-- AUTO_INCREMENT for table `students_requirement`
--
ALTER TABLE `students_requirement`
  MODIFY `student_req_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=48;

--
-- AUTO_INCREMENT for table `student_balance`
--
ALTER TABLE `student_balance`
  MODIFY `balance_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=118;

--
-- AUTO_INCREMENT for table `student_detail`
--
ALTER TABLE `student_detail`
  MODIFY `student_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=69;

--
-- AUTO_INCREMENT for table `student_family_details`
--
ALTER TABLE `student_family_details`
  MODIFY `student_fam_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=87;

--
-- AUTO_INCREMENT for table `student_grades`
--
ALTER TABLE `student_grades`
  MODIFY `studentgrade_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- AUTO_INCREMENT for table `student_reservepay`
--
ALTER TABLE `student_reservepay`
  MODIFY `reservepay` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT for table `stud_history_details`
--
ALTER TABLE `stud_history_details`
  MODIFY `stud_his_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=63;

--
-- AUTO_INCREMENT for table `subjects`
--
ALTER TABLE `subjects`
  MODIFY `subject_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=43;

--
-- AUTO_INCREMENT for table `subjectype`
--
ALTER TABLE `subjectype`
  MODIFY `sub_type_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `timestamp`
--
ALTER TABLE `timestamp`
  MODIFY `timestamp_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;

--
-- AUTO_INCREMENT for table `tuition_fee`
--
ALTER TABLE `tuition_fee`
  MODIFY `tf_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=38;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `classroom`
--
ALTER TABLE `classroom`
  ADD CONSTRAINT `dekete` FOREIGN KEY (`classroom_type`) REFERENCES `classroom_type` (`classroom_type_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `orno`
--
ALTER TABLE `orno`
  ADD CONSTRAINT `deleteorsno` FOREIGN KEY (`sno`) REFERENCES `student_detail` (`sno`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `sched_section`
--
ALTER TABLE `sched_section`
  ADD CONSTRAINT `asd` FOREIGN KEY (`subject_id`) REFERENCES `subjects` (`subject_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `de` FOREIGN KEY (`timestamp_id`) REFERENCES `timestamp` (`timestamp_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `delete` FOREIGN KEY (`teacher_ID`) REFERENCES `specialization` (`teacher_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `delete2` FOREIGN KEY (`classroom_id`) REFERENCES `classroom` (`classroom_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `des` FOREIGN KEY (`sect_id`) REFERENCES `sections` (`sect_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `sections`
--
ALTER TABLE `sections`
  ADD CONSTRAINT `deletesec` FOREIGN KEY (`teacher_ID`) REFERENCES `specialization` (`teacher_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `specialization`
--
ALTER TABLE `specialization`
  ADD CONSTRAINT `deletespec` FOREIGN KEY (`acc_id`) REFERENCES `useraccounts` (`acc_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `studentenrolledinfo`
--
ALTER TABLE `studentenrolledinfo`
  ADD CONSTRAINT `deletesectss` FOREIGN KEY (`sect_id`) REFERENCES `sections` (`sect_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `deletesno` FOREIGN KEY (`sno`) REFERENCES `student_detail` (`sno`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `students_requirement`
--
ALTER TABLE `students_requirement`
  ADD CONSTRAINT `sd` FOREIGN KEY (`student_no`) REFERENCES `student_detail` (`sno`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `studreqidsde` FOREIGN KEY (`req_id`) REFERENCES `school_requirements` (`req_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `student_balance`
--
ALTER TABLE `student_balance`
  ADD CONSTRAINT `deletebalance` FOREIGN KEY (`sno`) REFERENCES `student_detail` (`sno`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `student_family_details`
--
ALTER TABLE `student_family_details`
  ADD CONSTRAINT `deletefam` FOREIGN KEY (`sno`) REFERENCES `student_detail` (`sno`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `student_grades`
--
ALTER TABLE `student_grades`
  ADD CONSTRAINT `deletegrades` FOREIGN KEY (`sno`) REFERENCES `student_detail` (`sno`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `deletesect` FOREIGN KEY (`sect_id`) REFERENCES `sections` (`sect_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `deleteteacher` FOREIGN KEY (`teacher_ID`) REFERENCES `specialization` (`teacher_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `student_reservepay`
--
ALTER TABLE `student_reservepay`
  ADD CONSTRAINT `deleterserve` FOREIGN KEY (`sno`) REFERENCES `student_detail` (`sno`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `stud_history_details`
--
ALTER TABLE `stud_history_details`
  ADD CONSTRAINT `deletehis` FOREIGN KEY (`sno`) REFERENCES `student_detail` (`sno`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `subjects`
--
ALTER TABLE `subjects`
  ADD CONSTRAINT `cascadetypesub` FOREIGN KEY (`subject_type_id`) REFERENCES `subjectype` (`sub_type_id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

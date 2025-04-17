-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 17 Apr 2025 pada 19.54
-- Versi server: 10.4.32-MariaDB
-- Versi PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_kereta`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `tiket_kereta`
--

CREATE TABLE `tiket_kereta` (
  `id_tiket` int(11) NOT NULL,
  `nama_penumpang` varchar(100) DEFAULT NULL,
  `asal` varchar(50) DEFAULT NULL,
  `tujuan` varchar(50) DEFAULT NULL,
  `tanggal_berangkat` date DEFAULT NULL,
  `jam` time DEFAULT NULL,
  `harga` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `tiket_kereta`
--

INSERT INTO `tiket_kereta` (`id_tiket`, `nama_penumpang`, `asal`, `tujuan`, `tanggal_berangkat`, `jam`, `harga`) VALUES
(1, 'Ahmad Fauzi', 'Jakarta', 'Surabaya', '2025-04-21', '08:00:00', 350000),
(2, 'Budi Santoso', 'Bandung', 'Yogyakarta', '2025-04-22', '10:00:00', 250000),
(5, 'Citra dewi', 'Semarang', 'Malang', '2025-04-01', '13:00:00', 450000);

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `tiket_kereta`
--
ALTER TABLE `tiket_kereta`
  ADD PRIMARY KEY (`id_tiket`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `tiket_kereta`
--
ALTER TABLE `tiket_kereta`
  MODIFY `id_tiket` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

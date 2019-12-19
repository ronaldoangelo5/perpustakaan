/*
Navicat MySQL Data Transfer

Source Server         : localhost_3306
Source Server Version : 50505
Source Host           : localhost:3306
Source Database       : perpustakaan

Target Server Type    : MYSQL
Target Server Version : 50505
File Encoding         : 65001

Date: 2019-12-19 11:06:32
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `tb_anggota`
-- ----------------------------
DROP TABLE IF EXISTS `tb_anggota`;
CREATE TABLE `tb_anggota` (
  `kd_anggota` varchar(8) NOT NULL,
  `nama` varchar(32) DEFAULT NULL,
  `alamat` varchar(32) DEFAULT NULL,
  `no_telp` varchar(32) DEFAULT NULL,
  `role` char(1) DEFAULT NULL,
  PRIMARY KEY (`kd_anggota`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tb_anggota
-- ----------------------------
INSERT INTO `tb_anggota` VALUES ('AGT00001', 'ALDO', 'HERTASNING', '92130912309', 'M');

-- ----------------------------
-- Table structure for `tb_buku`
-- ----------------------------
DROP TABLE IF EXISTS `tb_buku`;
CREATE TABLE `tb_buku` (
  `kd_buku` varchar(16) DEFAULT NULL,
  `judul` varchar(32) DEFAULT NULL,
  `kd_pengarang` varchar(8) DEFAULT NULL,
  `kd_penerbit` varchar(8) DEFAULT NULL,
  `tahun_terbit` int(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tb_buku
-- ----------------------------
INSERT INTO `tb_buku` VALUES ('BKU1912000001', 'BOBO', 'PNG00001', 'PBT00001', '2012');
INSERT INTO `tb_buku` VALUES ('BKU1912000002', 'HARY POTER', 'PNG00001', 'PBT00002', '2000');

-- ----------------------------
-- Table structure for `tb_keranjang`
-- ----------------------------
DROP TABLE IF EXISTS `tb_keranjang`;
CREATE TABLE `tb_keranjang` (
  `no` int(2) NOT NULL AUTO_INCREMENT,
  `kd_buku` varchar(13) DEFAULT NULL,
  `judul` varchar(32) DEFAULT NULL,
  `tgl_kembali` date DEFAULT NULL,
  PRIMARY KEY (`no`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tb_keranjang
-- ----------------------------

-- ----------------------------
-- Table structure for `tb_peminjaman`
-- ----------------------------
DROP TABLE IF EXISTS `tb_peminjaman`;
CREATE TABLE `tb_peminjaman` (
  `kd_peminjaman` varchar(13) NOT NULL,
  `tanggal` date DEFAULT NULL,
  `kd_anggota` varchar(8) DEFAULT NULL,
  PRIMARY KEY (`kd_peminjaman`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tb_peminjaman
-- ----------------------------
INSERT INTO `tb_peminjaman` VALUES ('PJM1912000001', '2019-12-19', 'AGT00001');
INSERT INTO `tb_peminjaman` VALUES ('PJM1912000002', '2019-12-19', 'AGT00001');

-- ----------------------------
-- Table structure for `tb_peminjaman_detail`
-- ----------------------------
DROP TABLE IF EXISTS `tb_peminjaman_detail`;
CREATE TABLE `tb_peminjaman_detail` (
  `kd_peminjaman` varchar(13) DEFAULT NULL,
  `kd_buku` varchar(13) DEFAULT NULL,
  `tgl_kembali` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tb_peminjaman_detail
-- ----------------------------
INSERT INTO `tb_peminjaman_detail` VALUES ('PJM1912000002', 'BKU1912000002', '2020-01-02');

-- ----------------------------
-- Table structure for `tb_penerbit`
-- ----------------------------
DROP TABLE IF EXISTS `tb_penerbit`;
CREATE TABLE `tb_penerbit` (
  `kd_penerbit` varchar(8) DEFAULT NULL,
  `nama_penerbit` varchar(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tb_penerbit
-- ----------------------------
INSERT INTO `tb_penerbit` VALUES ('PBT00001', 'GRAMEDIA');
INSERT INTO `tb_penerbit` VALUES ('PBT00002', 'ERLANGA');

-- ----------------------------
-- Table structure for `tb_pengarang`
-- ----------------------------
DROP TABLE IF EXISTS `tb_pengarang`;
CREATE TABLE `tb_pengarang` (
  `kd_pengarang` varchar(8) NOT NULL,
  `nama_pengarang` varchar(32) DEFAULT NULL,
  PRIMARY KEY (`kd_pengarang`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tb_pengarang
-- ----------------------------
INSERT INTO `tb_pengarang` VALUES ('PNG00001', 'TINI');

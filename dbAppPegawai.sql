create database dbAppPegawai;

use dbAppPegawai;

create table jabatan(
    kodeJabatan tinyint not null primary key ,
    namaJabatan varchar(30) not null
);

create table pegawai(
    nip char(5) not null primary key ,
    nama varchar(50) not null ,
    jenis_kelamin char(1) not null check ( jenis_kelamin in ('L','P')) ,
    alamat text not null,
    kodeJabatan tinyint not null,
    foreign key (kodeJabatan) references jabatan(kodeJabatan)
                    on delete  cascade
                    on update  cascade

);

insert into jabatan values (1, 'Ketua');
insert into jabatan values (2, 'Wakil Ketua');
insert into jabatan values (3, 'Anggota');

insert into pegawai values ('92SA1','Rizal Alfikri','L','Brobot RT03/1 Bojongsari Purbalingga',1);
insert into pegawai values ('00SB1','Sinta Purwaningrum','P','Brobot RT03/1 Bojongsari Purbalingga', 2);
insert into pegawai values ('21SA1','Muhammad Arsya Alfikri','L','Brobot RT03/1 Bojongsari Purbalingga', 3);

select * from pegawai;

GRANT ALL ON *.* to root@'192.168.56.1' IDENTIFIED BY '';
FLUSH PRIVILEGES;

select a.nip, a.nama, a.jenis_kelamin, a.alamat, b.namaJabatan from pegawai a, jabatan b where a.kodeJabatan = b.kodeJabatan

select a.nip, a.nama, a.jenis_kelamin, a.alamat, b.namaJabatan from pegawai a, jabatan b where a.kodeJabatan = b.kodeJabatan
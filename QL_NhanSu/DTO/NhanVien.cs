﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace DTO
{
    public class NhanVien
    {
        private string ma;
        private string ten;
        private DateTime ngaysinh;
        private string gioitinh;
        private int cmnd;
        private object anh;
        private string dantoc;
        private string tongiao;
        private string trinhdongoainguma;
        private string chucdanhma;
        private string trinhdohocvanma;
        private DateTime ngaykihopdong;
        private DateTime ngayhethanhopdong;
        private string matkhau;

        public string Ma
        {
            get
            {
                return ma;
            }

            set
            {
                ma = value;
            }
        }

        public string Ten
        {
            get
            {
                return ten;
            }

            set
            {
                ten = value;
            }
        }

        public DateTime Ngaysinh
        {
            get
            {
                return ngaysinh;
            }

            set
            {
                ngaysinh = value;
            }
        }

        public string Gioitinh
        {
            get
            {
                return gioitinh;
            }

            set
            {
                gioitinh = value;
            }
        }

        public int Cmnd
        {
            get
            {
                return cmnd;
            }

            set
            {
                cmnd = value;
            }
        }

        public string Dantoc
        {
            get
            {
                return dantoc;
            }

            set
            {
                dantoc = value;
            }
        }

        public string Tongiao
        {
            get
            {
                return tongiao;
            }

            set
            {
                tongiao = value;
            }
        }

        public string Trinhdongoainguma
        {
            get
            {
                return trinhdongoainguma;
            }

            set
            {
                trinhdongoainguma = value;
            }
        }

        public string Chucdanhma
        {
            get
            {
                return chucdanhma;
            }

            set
            {
                chucdanhma = value;
            }
        }

        public string Trinhdohocvanma
        {
            get
            {
                return trinhdohocvanma;
            }

            set
            {
                trinhdohocvanma = value;
            }
        }

        public DateTime Ngaykihopdong
        {
            get
            {
                return ngaykihopdong;
            }

            set
            {
                ngaykihopdong = value;
            }
        }

        public DateTime Ngayhethanhopdong
        {
            get
            {
                return ngayhethanhopdong;
            }

            set
            {
                ngayhethanhopdong = value;
            }
        }

        public string Matkhau
        {
            get
            {
                return matkhau;
            }

            set
            {
                matkhau = value;
            }
        }

        public object Anh
        {
            get
            {
                return anh;
            }

            set
            {
                anh = value;
            }
        }
        public int Them_NV()
        {
           return DATA.ADD_Nhanvien(ma,ten,ngaysinh,gioitinh,cmnd,anh,dantoc,tongiao,trinhdongoainguma,chucdanhma,trinhdohocvanma,ngaykihopdong,ngayhethanhopdong,matkhau);
        }
        public int Sua_NV()
        {
            return DATA.Change_Nhanvien(ma,ten,ngaysinh,gioitinh,cmnd,anh,dantoc,tongiao,trinhdongoainguma,chucdanhma,trinhdohocvanma);

        }
        public static int Xoa_NV(string ma)
        {
            return DATA.DELETE_Nhanvien(ma);
        }
        public static DataTable Xem_NV(string ma)
        {
            return DATA.View_nvma(ma);
        }
        public static DataTable Xem_NVpb(string pb)
        {
            return DATA.View_nvpb(pb);
        }
        public static DataTable Xem_NVcd(string cd)
        {
            return DATA.View_nvcd(cd);
        }
    }
}

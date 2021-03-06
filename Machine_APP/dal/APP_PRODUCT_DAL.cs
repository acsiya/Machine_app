﻿using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Machine_APP.model;
using System.Collections.ObjectModel;

namespace Machine_APP.dal
{
    public class APP_PRODUCT_DAL
    {
        public PRODUCT porduct = null;
        DBhelp db = new DBhelp();
        public APP_PRODUCT_DAL() { }


        public ObservableCollection<ProductView> serpveiw(List<PRODUCT> plist)
        {
            ObservableCollection<ProductView> pvlist = new ObservableCollection<ProductView>();
            foreach (PRODUCT item in plist)
            {
                ProductView pv = new ProductView();
                pv.ChannelCode1 = item.ChannelCode1;
                pv.MachineType1 = item.MachineType1;
                pv.MachineCode1 = item.MachineCode1;
                pv.ProductName1 = item.ProductName1;
                pv.Price1 = item.Price1;
                pv.DiscountPrice1 = item.DiscountPrice1;
                pv.DiscountDate1 = item.DiscountDate1;
                pv.XFlag1 = item.XFlag1;
                pv.YFlag1 = item.YFlag1;
                pv.ChannelStatus1 = item.ChannelStatus1;
                pv.PictureUrl1 = item.PictureUrl1;
                pv.ChannelLength1 = item.ChannelLength1;
                pv.ChannelWidth1 = item.ChannelWidth1;
                pv.ChannelType1 = item.ChannelType1;
                pv.ProductNum1 = item.ProductNum1;
                pv.CapacityNum1 = item.CapacityNum1;
                pv.IsDisable1 = item.IsDisable1;
                pv.Creator1 = item.Creator1;
                pv.CreateDate1 = item.CreateDate1;
                pv.Modifier1 = item.Modifier1;
                pv.ModifyDate1 = item.ModifyDate1;
                pv.choosenum1 = 0;
                pvlist.Add(pv);
            }
            return pvlist;

        }



        /// <summary>
        /// 获取所有商品
        /// </summary>
        /// <returns></returns>
        public List<PRODUCT> getlist()
        {
            try
            {
                List<PRODUCT> procucts = new List<PRODUCT>();
                string sqlcouint = @"SELECT COUNT(*) FROM APP_PRODUCT";
                string count = db.getcount(sqlcouint);
                int productcount = 0;
                int.TryParse(count, out productcount);
                string sqlbing = @"SELECT     (SELECT COUNT(*)     FROM [APP_PRODUCT] AS t2     WHERE t2.ChannelCode <= t1.ChannelCode) AS rowNum,   * FROM [APP_PRODUCT] t1 where rownum={0} ORDER BY t1.ChannelCode asc";
                for (int i = 1; i <= productcount; i++)
                {

                    string sqlbing2 = string.Format(sqlbing, i.ToString());
                    PRODUCT p = db.getsinglePRODUCT(sqlbing2);
                    procucts.Add(p);
                }
                return procucts;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 获取带查询条件的商品
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public List<PRODUCT> getlistbysingle(string sql)
        {
            try
            {
                List<PRODUCT> procucts = new List<PRODUCT>();
                string sqlcouint = @"SELECT COUNT(*) FROM APP_PRODUCT as t2 where 1=1 " + sql;
                string count = db.getcount(sqlcouint);
                int productcount = 0;
                int.TryParse(count, out productcount);
                sqlcouint = sqlcouint + " and t2.ChannelCode <= t1.ChannelCode";
                string sqlbing = @"SELECT     ({2}) AS rowNum,   * FROM 
[APP_PRODUCT] t1 where rownum={0} {1} ORDER BY t1.ChannelCode asc";
                for (int i = 1; i <= productcount; i++)
                {

                    string sqlbing2 = string.Format(sqlbing, i.ToString(), sql, sqlcouint);
                    PRODUCT p = db.getsinglePRODUCT(sqlbing2);
                    procucts.Add(p);
                }
                return procucts;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 更新商品
        /// </summary>
        /// <param name="sql"></param>
        public void updateforsql(string sql)
        {
            try
            {
                DBhelp db = new DBhelp();
                db.UpdateRow(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void insertproduct(PRODUCT pro)
        {
            try
            {
                string sql = "INSERT INTO APP_PRODUCT VALUES ('{0}', {1}, '{2}', '{3}', {4}, {5}, '{6}', {7}, {8}, {9}, '{10}',{11}, {12}, {13}, {14},{15}, {16}, '{17}', '{18}', '{19}', '{20}');";
                sql = string.Format(sql, pro.ChannelCode1, pro.MachineType1, pro.MachineCode1, pro.ProductName1, pro.Price1, pro.DiscountPrice1, pro.DiscountDate1, pro.XFlag1, pro.YFlag1, pro.ChannelStatus1, pro.PictureUrl1, pro.ChannelLength1, pro.ChannelWidth1, pro.ChannelType1, pro.ProductNum1, pro.CapacityNum1, pro.IsDisable1, pro.Creator1, pro.CreateDate1, pro.Modifier1, pro.ModifyDate1);
                db.InsertRow(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void updateproduct(PRODUCT pro)
        {
            try
            {

                string sql = " UPDATE APP_PRODUCT SET ChannelCode='{0}', MachineType={1}, MachineCode='{2}', ProductName='{3}', Price={4}, DiscountPrice={5}, DiscountDate='{6}', XFlag={7}, YFlag={8}, ChannelStatus={9}, PictureUrl='{10}', ChannelLength={11}, ChannelWidth={12}, ChannelType={13}, ProductNum={14}, CapacityNum={15}, IsDisable={16}, Creator='{17}', CreateDate='{18}', Modifier='{19}', ModifyDate='{20}' WHERE (ChannelCode='{0}') AND (MachineCode='{2}');";
                sql = string.Format(sql, pro.ChannelCode1, pro.MachineType1, pro.MachineCode1, pro.ProductName1, pro.Price1, pro.DiscountPrice1, pro.DiscountDate1, pro.XFlag1, pro.YFlag1,
                    pro.ChannelStatus1, pro.PictureUrl1, pro.ChannelLength1, pro.ChannelWidth1, pro.ChannelType1, pro.ProductNum1, pro.CapacityNum1, pro.IsDisable1, pro.Creator1, pro.CreateDate1,
                    pro.Modifier1, pro.ModifyDate1);
                db.UpdateRow(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void deleteAllproduct()
        {
            try
            {
                string sql = "delete from APP_PRODUCT";
                DBhelp db = new DBhelp();
                db.UpdateRow(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}

using System;
using System.Data;
using System.IO;
using System.Ling;
using System.Text.Json;
namespace Sundial_
{
    //==============================================枚举:设备状态================================================
    public enum DeviceStatus
    {
        Normal,//正常
        Warning, //警告
        Fault //故障
    }
    //===============================================设备实体类=====================================================
    public class Device
    {
        public int Id {get; set;}   //设备编号
        public string Name {get; set;}= string.Empty; //设备名称
        public string Type {get; set;}= string.Empty; //安装位置
        public float Temperature {get; set;} //温度°C
        public DeviceStatus Status {get; set;} //状态
        public DateTime LastUpadeteTime {get; set;} //最后更新时间
        public bool IsOnline {get; set;} =true; //是否在线
    }
}
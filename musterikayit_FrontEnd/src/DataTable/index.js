import React,{ useState,useEffect } from "react";
import axios from "axios";
import { Table } from "antd"

const DataTable = () =>{
    const [gridData,setGridData] = useState([]);
    const[loading,setLoading] = useState(false);

    useEffect(() => {
        loadData();
    }, []);

    const loadData = async () =>{
        setLoading(true);
        const response = await axios.get(
            "https://localhost:44374/api/customers"
            );
        setGridData(response.data);
        setLoading(false);
    };


    const modifiedData = gridData.map(row =>({
        id: row.id,
        Ad: row.ad,
        Soyad: row.soyad,
        TcNo:row.tcNo,
        DogumYeri: row.dogumYeri,
        Firma:row.firma,
        Sorumlu:row.firmaSorumlusu,
        Unvan:row.unvan,
        Tel:row.tel,
        CepTel:row.ceptel,
        DogumTarihi:row.dogumTarihi,
        KayıtTarihi:row.kayitTarihi,
        DüzenlemeTarihi:row.düzenlemeTarihi

        
    }))

console.log("modifiedData",modifiedData);
    
    const columns = [{
        title:"id",
        dataIndex:'id',
        key :'id'
    },
    {
        title:"Ad",
        dataIndex:"Ad",
        align:"center",
        width:150
    },
    {
        title:"Soyad",
        dataIndex:"Soyad",
        align:"center",
        width:150
    },
    {
        title:"TcNo",
        dataIndex:"TcNo",
        align:"center",
        width:150
    },
    {
        title:"DogumYeri",
        dataIndex:"DogumYeri",
        align:"center",
        width:150
    },
    {
        title:"Firma",
        dataIndex:"Firma",
        align:"center",
        width:150
    },
    {
        title:"Sorumlu",
        dataIndex:"Sorumlu",
        align:"center",
        width:150
    },
    {
        title:"Unvan",
        dataIndex:"Unvan",
        align:"center",
        width:150
    },
    {
        title:"Tel",
        dataIndex:"Tel",
        align:"center",
        width:150
    },
    {
        title:"CepTel",
        dataIndex:"CepTel",
        align:"center",
        width:150
    },
    {
        title:"DogumTarihi",
        dataIndex:"DogumTarihi",
        align:"center",
        width:150
    },
    {
        title:"KayıtTarihi",
        dataIndex:"KayıtTarihi",
        align:"center",
        width:150
    },
    {
        title:"DüzenlemeTarihi",
        dataIndex:"DüzenlemeTarihi",
        align:"center",
        width:150
    },


    
];

    return (
        <div >
            <h2>Data</h2>
            <Table 
            columns = {columns}
            dataSource = {modifiedData}
            bordered
            loading = {loading}
            >
            </Table>
        </div>
    );
}


export default DataTable;
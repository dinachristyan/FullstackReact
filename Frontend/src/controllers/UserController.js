import React, { Component } from 'react';
import DataTable from 'react-data-table-component';

const columns1 = [
  {
    name: 'Owner',
    selector: row => row.owner,
    sortable: true
  },
  {
    name: 'Alamat',
    selector: row => row.alamat,
    sortable: true
  },
];

const data1 = [
  {
    id: 1,
    owner: 'Alumni Store',
    alamat: 'Jombang',
  },
  {
    id: 2,
    owner: 'Topsell',
    alamat: 'Mojoagung',
  },
];

const columns2 = [
  {
    name: 'Nama',
    selector: row => row.name,
    sortable: true
  },
  {
    name: 'Hobi',
    selector: row => row.hobi,
    sortable: true
  },
];

const data2 = [
  {
    id: 1,
    name: 'david',
    hobi: 'sepak bola',
  },
  {
    id: 2,
    name: 'satrio',
    hobi: 'Menari',
  },
];

class Datauser extends Component {
  render() {
    return (
      <div>
        
        <DataTable
          columns={columns1}
          data={data1}
         
        />
        
        <hr style={{ borderTop: '1px solid black', width: '100%' }} />
        <DataTable
          columns={columns2}
          data={data2}
          pagination
        />
      </div>
    );
  }
}

export default Datauser;

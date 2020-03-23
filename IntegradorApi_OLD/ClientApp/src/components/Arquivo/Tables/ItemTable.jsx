import React, { Component } from 'react'
import { Table, Button } from 'reactstrap';
import ItemModal from '../Modals/ItemModal'

export class ItemTable extends Component {
    static displayName = ItemTable.name;

    deleteItem = id => {
        let confirmDelete = window.confirm('Deseja deketar este registro?')
        if (confirmDelete) {
            fetch('api/arquivo/ArquivoDelete/'+id, {
                method: 'delete',
                headers: {
                    'Content-Type': 'application/json'
                },
                body: JSON.stringify({
                    id
                })
            })
                .then(response => response.json())
                .then(item => {
                    this.props.deleteItemFromState(id)
                })
                .catch(err => console.log(err))
        }

    }

    render() {

        const items = this.props.items.map(item => {
            return (
                <tr key={item.id}>
                    <th scope="row">{item.id}</th>
                    <td>{item.descricao}</td>
                    <td>{item.ativo}</td>
                    <td>{item.dataInclusao}</td>
                    <td>{item.usuarioIdInclusao}</td>
                    <td>{item.dataAlteracao}</td>
                    <td>{item.usuarioIdAlteracao}</td>
                    <td>
                        <div style={{ width: "150px" }}>
                            <ItemModal buttonLabel="Altera" item={item} updateState={this.props.updateState} />
                            {' '}
                            <Button color="danger" onClick={() => this.deleteItem(item.id)}>Deleta</Button>
                        </div>
                    </td>
                </tr>
            )
        })

        return (
            <Table responsive hover>
                <thead>
                    <tr>
                        <th>ID</th>
                        <th>Descrição</th>
                        <th>Ativo</th>
                        <th>Inclisão</th>
                        <th>Usr. Inclusão</th>
                        <th>Alteração</th>
                        <th>Usr. Alteração</th>
                        <th>Ações</th>
                    </tr>
                </thead>
                <tbody>
                    {items}
                </tbody>
            </Table>
        )
    }
}

export default ItemTable
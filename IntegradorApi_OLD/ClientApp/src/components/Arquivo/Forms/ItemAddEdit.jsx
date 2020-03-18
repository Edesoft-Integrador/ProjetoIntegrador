import React, { Component } from 'react'
import { Button, Form, FormGroup, Label, Input } from 'reactstrap';

export class ItemAddEdit extends Component {
    static displayName = ItemAddEdit.name;
    entity = {id: 0, descricao: '', ativo: ''}

    onChange = e => {
        this.setState({ [e.target.name]: e.target.value })
    }

    submitFormAdd = e => {
        e.preventDefault();
        fetch('api/Arquivo/Post', {
            method: 'post',
            headers: {
                Accept: 'application/json',
                'Content-Type': 'application/json',
            },
            body: JSON.stringify(this.entity
                //Descricao: this.state.descricao,
                //Ativo: this.state.ativo
            )


        })
            .then(res => res.json())
            .then(item => {
                this.props.addUserToState(item);
                this.props.toggle();
            })
            .catch(err => console.log(err));

    }

    
    submitFormEdit = e => {
        e.preventDefault()
        fetch('api/Arquivo/ArquivoPut', {
            method: 'put',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({
                id: this.entity.id,
                descricao: this.entity.descricao,
                ativo: this.entity.ativo,
            })
        })
            .then(response => response.json())
            .then(item => {
                if (Array.isArray(item)) {
                    // console.log(item[0])
                    this.props.updateState(item[0])
                    this.props.toggle()
                } else {
                    console.log('failure')
                }
            })
            .catch(err => console.log(err))
    }

    componentDidMount() {
        // if item exists, populate the state with proper data
        if (this.props.item) {
            const { id, descricao, ativo } = this.props.item
            this.setState({ id, descricao, ativo })
        }
    }

    render() {
        return (
            <Form onSubmit={this.props.item ? this.submitFormEdit : this.submitFormAdd}>
                <FormGroup>
                    <Label for="descricao">Descrição</Label>
                    <Input type="text" name="descricao" id="descricao" onChange={this.onChange} value={this.entity.descricao === null ? '' : this.entity.descricao} />
                </FormGroup>
                <FormGroup className={this.entity.descricao === null ? 'show' : 'hidden'}>
                    <div class="custom-control custom-checkbox mb-3">
                        <Input type="checkbox" class="custom-control-input" name="ativo" id="ativo" onChange={this.onChange} value={this.entity.ativo === null ? '' : this.entity.ativo} />
                        <label for="ativo">Ativo</label>
                    </div>
                </FormGroup>
                <Button>Grava</Button>
            </Form>
         );
    }
}
export default ItemAddEdit




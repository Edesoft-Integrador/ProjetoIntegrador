import React, { Component } from 'react'
import { Container, Row, Col } from 'reactstrap';
import ItemModal from '../Arquivo/Modals/ItemModal'
import ArquivoTable from '../Arquivo/Tables/ItemTable'

export class Arquivo extends Component {
    static displayName = Arquivo.name;

    constructor(props) {
        super(props);
        this.state = { items: [], loading: true };
    }

    componentDidMount() {
        this.getItems();
    }

    async getItems() {
        const response = await fetch('api/Arquivo/Search');
        const data = await response.json();

        this.setState({ items: data, loading: false });
    }

    addItemToState = (item) => {
        this.setState(prevState => ({
            items: [...prevState.items, item]
        }))
    }

    updateState = (item) => {
        const itemIndex = this.state.items.findIndex(data => data.id === item.Id)
        const newArray = [
            // destructure all items from beginning to the indexed item
            ...this.state.items.slice(0, itemIndex),
            // add the updated item to the array
            item,
            // add the rest of the items to the array from the index after the replaced item
            ...this.state.items.slice(itemIndex + 1)
        ]
        this.setState({ items: newArray })
    }

    deleteItemFromState = (id) => {
        const updatedItems = this.state.items.filter(item => item.Id !== id)
        this.setState({ items: updatedItems })
    }

    render() {
        return (

            <Container className="App">
                <Row>
                    <Col>
                        <h1 style={{ margin: "20px 0" }}>Arquivo</h1>
                    </Col>
                </Row>
                <Row>
                    <Col>
                        <ItemModal buttonLabel="Novo" addItemToState={this.addItemToState} />
                    </Col>
                </Row>
                <Row>
                    <Col>
                        <ArquivoTable items={this.state.items} updateState={this.updateState} deleteItemFromState={this.deleteItemFromState} />
                    </Col>
                </Row>
            </Container>
        )
    }
}

export default Arquivo
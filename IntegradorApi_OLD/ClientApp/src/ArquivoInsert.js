import React from 'react';
import { Row, Form, Col, Button } from 'reactstrap';

export class ArquivoInsert extends React.Component {
  constructor(props) {
    super(props);
    this.initialState = {
      id: '',
      productName: '',
      price: '',
      sku: ''
    }

    if(props.product){
      this.state = props.product
    } else {
      this.state = this.initialState;
    }

    this.handleChange = this.handleChange.bind(this);
    this.handleSubmit = this.handleSubmit.bind(this);
  }

  handleChange(event) {
    const name = event.target.name;
    const value = event.target.value;

    this.setState({
      [name]: value
    })
  }

  handleSubmit(event) {
    event.preventDefault();
    this.props.onFormSubmit(this.state);
    this.setState(this.initialState);
  }

  render() {

    let pageTitle;
    if(this.state.id) {
      pageTitle = <h2>Edit Product</h2>
    } else {
      pageTitle = <h2>Add Product</h2>
    }

    return(
      <div>
      </div>
    )
  }
}
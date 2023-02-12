import React, { useState, useEffect } from 'react';
import { Container, Form, FormControl, FormGroup, FormLabel } from 'react-bootstrap';


export const EnrollmentPage=()=> {
    return <Container>
        <Form>
        <FormGroup>
                <FormLabel>Direct Payment</FormLabel>
            </FormGroup>
            <FormGroup>
                <FormLabel>Card Number</FormLabel>
                <FormControl type="number" />
            </FormGroup>
            <FormGroup>
                <FormLabel>Card CVV</FormLabel>
                <FormControl type="number" />
            </FormGroup>
            <FormGroup>
                <FormLabel>Card Owner</FormLabel>
                <FormControl type="text" />
            </FormGroup>
            
        </Form>
    </Container>
}
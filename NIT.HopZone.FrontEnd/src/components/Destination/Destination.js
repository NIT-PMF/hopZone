import React from 'react';
import { ListGroup, ListGroupItem, Container } from 'reactstrap';
import gql from 'graphql-tag';
import { useQuery } from '@apollo/react-hooks';
import 'bootstrap/dist/css/bootstrap.min.css';



const GET_SPOTS = gql`
{
  spots{
    username
    description
    logitude
    latitude
  }
}`;

const Destination = (props) => {
  const { loading, error, data } = useQuery(GET_SPOTS);

  return (
  <div>
    {loading ? 'loading' : (
      <Container>
        <ListGroup>
            {data.spots.map(item => (
              <ListGroup>
                <ListGroupItem color="primary">{item.description}</ListGroupItem>
            <ListGroupItem color="danger">{item.latitude}</ListGroupItem>
            <ListGroupItem color="danger">{item.logitude}</ListGroupItem>
                <ListGroupItem color="success">{item.username}</ListGroupItem>
                <br />
              </ListGroup>

          ))}
        </ListGroup>
        </Container>)}
      </div>
  );

}

export default Destination;

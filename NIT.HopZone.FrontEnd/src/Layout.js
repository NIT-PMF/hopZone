import React, { Component } from 'react';
import { Container } from 'reactstrap';
import { ApolloProvider } from '@apollo/react-hooks';
import ApolloClient from 'apollo-boost'
import withAuth from '@okta/okta-react/dist/withOktaAuth';


class Layout extends Component {
  static displayName = Layout.name;

  render() {
    const clientParam = { uri: '/graphql' };
    let myAuth = this.props && this.props.auth;
    if (myAuth) {
      clientParam.request = async (operation) => {
        let token = await myAuth.getAccessToken();
        operation.setContext({ headers: { authorization: token ? `Bearer ${token}` : '' } });
      }
    }
    const client = new ApolloClient(clientParam);
    return (
      <div>
        <Container>
          <ApolloProvider client={client} >
            {this.props.children}
          </ApolloProvider>
        </Container>
      </div>
    );
  }
}

export default Layout = withAuth(Layout);

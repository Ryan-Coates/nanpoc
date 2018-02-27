import * as React from 'react';
import { Route } from 'react-router-dom';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { FetchData } from './components/FetchData';
import { Counter } from './components/Counter';
import { SearchAds } from './components/SearchAds';
import { PostAds } from './components/PostAd';

export const routes = <Layout>
    <Route exact path='/' component={ Home } />
    <Route path='/counter' component={ Counter } />
    <Route path='/fetchdata' component={FetchData} />
    <Route path='/SearchAds' component={SearchAds} />
    <Route path='/PostAds' component={PostAds} />
</Layout>;

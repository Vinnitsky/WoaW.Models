import CounterExample from 'components/counter-example';
import FetchData from 'components/fetch-data';
import HomePage from 'components/home-page';

import ProductNew from 'modules/products/views/ProductNewView';
import ProductList from 'modules/products/views/ProductListView';
import ProductSettings from 'modules/products/views/ProductSettingsView';

import DocumentationAbout from 'components/views/aboutView';
import Documentation from 'components/views/documentationView';

export const routes = [
    { path: '/', component: HomePage, display: 'Home', style: 'glyphicon glyphicon-home' },
    { path: '/counter', component: CounterExample, display: 'Counter', style: 'glyphicon glyphicon-education' },
    { path: '/fetch-data', component: FetchData, display: 'Fetch data', style: 'glyphicon glyphicon-th-list' },
    { path: '/product/new', component: ProductNew, display: 'Product New' },
    { path: '/product/index', component: ProductList, display: 'Products List' },
    { path: '/product/settings', component: ProductSettings, display: 'Product Settings' },

    { path: '/docs', component: Documentation, display: 'Documentation' },
    { path: '/docs-about', component: DocumentationAbout, display: 'About' }
]

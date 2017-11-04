import CounterExample from 'components/counter-example'
import FetchData from 'components/fetch-data'
import HomePage from 'components/home-page'

import ProductNew from 'components/views/product-new'
import ProductList from 'components/views/product-list'
import ProductSettings from 'components/views/product-settings'

export const routes = [
    { path: '/', component: HomePage, display: 'Home', style: 'glyphicon glyphicon-home' },
    { path: '/counter', component: CounterExample, display: 'Counter', style: 'glyphicon glyphicon-education' },
    { path: '/fetch-data', component: FetchData, display: 'Fetch data', style: 'glyphicon glyphicon-th-list' },
    { path: '/product-new', component: ProductNew, display: 'Product New' },
    { path: '/product-list', component: ProductList, display: 'Products List' },
    { path: '/product-settings', component: ProductSettings, display: 'Product Settings' }
]

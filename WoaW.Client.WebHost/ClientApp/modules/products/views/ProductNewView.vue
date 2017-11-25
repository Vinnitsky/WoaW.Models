<template>
    <div id="newProduct" class="content-wrapper">
        <div class="content-heading">Product #000123</div>
        <form class="panel">
            <div role="tabpanel">
                <ul class="nav nav-tabs nav-justified">
                    <li role="presentation" class="active">
                        <a href="#edit" aria-controls="edit" role="tab" data-toggle="tab">Product Edit</a>
                    </li>
                    <li role="presentation">
                        <a href="#seo" aria-controls="seo" role="tab" data-toggle="tab">SEO Metadata</a>
                    </li>
                    <li role="presentation">
                        <a href="#picture" aria-controls="picture" role="tab" data-toggle="tab">Pictures</a>
                    </li>
                </ul>
                <div class="tab-content">
                    <div id="edit" role="tabpanel" class="tab-pane active">
                        <fieldset>
                            <div class="form-group">
                                <label class="col-md-2 control-label">Name:</label>
                                <div class="col-md-10">
                                    <input type="text" placeholder="Product name.." v-model="product.name" class="form-control" />
                                </div>
                            </div>
                        </fieldset>
                        <fieldset>
                            <div class="form-group">
                                <label class="col-md-2 control-label">Description:</label>
                                <div class="col-md-10">
                                    <textarea cols="5" v-model="product.description" placeholder="Short description.." class="form-control"></textarea>
                                </div>
                            </div>
                        </fieldset>
                        <fieldset>
                            <div class="form-group">
                                <label class="col-md-2 control-label">Price:</label>
                                <div class="col-md-10">
                                    <input type="text" v-model="product.price" placeholder="$ 123.20" class="form-control" />
                                </div>
                            </div>
                        </fieldset>
                        <fieldset>
                            <div class="form-group">
                                <label class="col-md-2 control-label">Quantity:</label>
                                <div class="col-md-10">
                                    <input type="number" v-model="product.quantity" placeholder="0" min="0" class="form-control" />
                                </div>
                            </div>
                        </fieldset>
                        <fieldset>
                            <div class="form-group">
                                <label class="col-md-2 control-label">Tax :</label>
                                <div class="col-md-10">
                                    <input type="text" placeholder="20%" class="form-control" />
                                </div>
                            </div>
                        </fieldset>
                        <fieldset>
                            <div class="form-group">
                                <label class="col-md-2 control-label">Status:</label>
                                <div class="col-md-10">
                                    <select class="form-control">
                                        <option value="">Select..</option>
                                        <option value="0">Public</option>
                                        <option value="1">Pending</option>
                                        <option value="2">Pending</option>
                                    </select>
                                </div>
                            </div>
                        </fieldset>
                    </div>
                    <div id="seo" role="tabpanel" class="tab-pane">
                        <fieldset>
                            <div class="form-group">
                                <label class="col-md-2 control-label">Title</label>
                                <div class="col-md-10">
                                    <input type="text" placeholder="Brief description.." class="form-control" />
                                </div>
                            </div>
                        </fieldset>
                        <fieldset>
                            <div class="form-group">
                                <label class="col-md-2 control-label">Description</label>
                                <div class="col-md-10">
                                    <textarea rows="5" placeholder="Max 255 characters..." class="form-control"></textarea>
                                </div>
                            </div>
                        </fieldset>
                        <fieldset>
                            <div class="form-group">
                                <label class="col-md-2 control-label">Keywords</label>
                                <div class="col-md-10">
                                    <textarea rows="5" placeholder="Max 1000 characters..." class="form-control"></textarea>
                                </div>
                            </div>
                        </fieldset>
                    </div>
                    <div id="picture" role="tabpanel" class="tab-pane">
                        <div class="row mb-lg">
                            <div class="col-xs-3">
                                <strong>Preview</strong>
                            </div>
                            <div class="col-xs-9">
                                <strong>Details</strong>
                            </div>
                        </div>
                        <div class="row mb-lg pb-lg bb">
                            <div class="col-xs-6 col-sm-3">
                                <a href="#" title="Product 1">
                                    <img src="img/bg7.jpg" alt="Product 1" class="img-responsive" />
                                </a>
                            </div>
                            <div class="col-xs-6 col-sm-9">
                                <fieldset>
                                    <div class="form-group">
                                        <input type="text" placeholder="Brief description.." class="form-control" />
                                    </div>
                                </fieldset>
                                <p>
                                    <strong>Picture type</strong>
                                </p>
                                <div class="radio c-radio c-radio-nofont">
                                    <label>
                                        <input type="radio" name="prod1-pic" value="option1" checked="" />
                                        <span></span>Primary
                                    </label>
                                </div>
                                <div class="radio c-radio c-radio-nofont">
                                    <label>
                                        <input type="radio" name="prod1-pic" value="option2" />
                                        <span></span>Thumbnail
                                    </label>
                                </div>
                                <div class="radio c-radio c-radio-nofont">
                                    <label>
                                        <input type="radio" name="prod1-pic" value="option3" />
                                        <span></span>Gallery
                                    </label>
                                </div>
                                <div class="text-right">
                                    <button type="button" class="btn btn-sm btn-danger">
                                        <em class="fa fa-times-circle fa-fw"></em>Remove
                                    </button>
                                </div>
                            </div>
                        </div>
                        <div class="row mb-lg pb-lg bb">
                            <div class="col-xs-6 col-sm-3">
                                <a href="#" title="Product 2">
                                    <img src="img/bg8.jpg" alt="Product 1" class="img-responsive" />
                                </a>
                            </div>
                            <div class="col-xs-6 col-sm-9">
                                <fieldset>
                                    <div class="form-group">
                                        <input type="text" placeholder="Brief description.." class="form-control" />
                                    </div>
                                </fieldset>
                                <p>
                                    <strong>Picture type</strong>
                                </p>
                                <div class="radio c-radio c-radio-nofont">
                                    <label>
                                        <input type="radio" name="prod2-pic" value="option1" checked="" />
                                        <span></span>Primary
                                    </label>
                                </div>
                                <div class="radio c-radio c-radio-nofont">
                                    <label>
                                        <input type="radio" name="prod2-pic" value="option2" />
                                        <span></span>Thumbnail
                                    </label>
                                </div>
                                <div class="radio c-radio c-radio-nofont">
                                    <label>
                                        <input type="radio" name="prod2-pic" value="option3" />
                                        <span></span>Gallery
                                    </label>
                                </div>
                                <div class="text-right">
                                    <button type="button" class="btn btn-sm btn-danger">
                                        <em class="fa fa-times-circle fa-fw"></em>Remove
                                    </button>
                                </div>
                            </div>
                        </div>
                        <div class="row mb-lg pb-lg">
                            <div class="col-xs-6 col-sm-3">
                                <a href="#" title="Product 3">
                                    <img src="img/bg10.jpg" alt="Product 1" class="img-responsive" />
                                </a>
                            </div>
                            <div class="col-xs-6 col-sm-9">
                                <fieldset>
                                    <div class="form-group">
                                        <input type="text" placeholder="Brief description.." class="form-control" />
                                    </div>
                                </fieldset>
                                <p>
                                    <strong>Picture type</strong>
                                </p>
                                <div class="radio c-radio c-radio-nofont">
                                    <label>
                                        <input type="radio" name="prod3-pic" value="option1" checked="" />
                                        <span></span>Primary
                                    </label>
                                </div>
                                <div class="radio c-radio c-radio-nofont">
                                    <label>
                                        <input type="radio" name="prod3-pic" value="option2" />
                                        <span></span>Thumbnail
                                    </label>
                                </div>
                                <div class="radio c-radio c-radio-nofont">
                                    <label>
                                        <input type="radio" name="prod3-pic" value="option3" />
                                        <span></span>Gallery
                                    </label>
                                </div>
                                <div class="text-right">
                                    <button type="button" class="btn btn-sm btn-danger">
                                        <em class="fa fa-times-circle fa-fw"></em>Remove
                                    </button>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </form>
        <div class="text-right mt-lg">
            <button type="button" class="btn btn-warning" v-on:click="onDiscard">Discard</button>
            <button type="button" class="btn btn-success" v-on:click="onSave">Save</button>
        </div>
    </div>
</template>

<script>
    import axios from "axios";

    export const HTTP = axios.create({
        baseURL: "http://localhost:7002/",
        headers: { Authorization: "Bearer {token}" }
    });

    export default {
        name: "newProduct",
        data() {
            return {
                errors: [],
                product: { id: '00000', name: "", description: "", price: 0, quantity: 0 }
            };
        },
        created() {
            var id = this.$route.query.id;
        },
        methods: {
            onSave() {
                if (this.product.id === '00000')
                    this.Create(this.product);
                else
                    this.Update(this.product.id, this.product);
            },
            onDiscard() { },
            Create(data) {
                //https://github.com/axios/axios
                //Content-Type: application/json; charset=utf-8
                HTTP
                    //.post('api/ProductData/', { body: this.product })
                    //.post('api/ProductData/',  this.product,{ headers: { Authorization: "Bearer " + token }} )
                    .put("api/ProductData/", data, {
                        headers: { "Content-Type": "application/json" }
                    }) //work
                    .then(response => {
                        console.log("post is OK");
                    })
                    .catch(e => {
                        debugger;
                        this.errors.push(e);
                    });
            },
            Update(id, data) {
                //https://github.com/axios/axios
                //Content-Type: application/json; charset=utf-8
                HTTP
                    //.post('api/ProductData/',  this.product,{ headers: { Authorization: "Bearer " + token }} )
                    .post('api/ProductData/?id=' + id, data, { headers: { "Content-Type": "application/json" } })
                    .then(response => {
                        console.log("post is OK");
                    })
                    .catch(e => {
                        debugger;
                        this.errors.push(e);
                    });
            }
        }
    };
</script>

<template>
    <div class="hello">
        <h1>{{ msg }}</h1>
        <div>
            <input type="checkbox" v-model="checked" value="html" id="html">
            <label for="html">HTM L</label>
            <br>
            <input type="checkbox" v-model="checked" value="js" id="js">
            <label for="js">JavaScript</label>
            <br>
            <input type="checkbox" v-model="checked" value="css" id="css">
            <label for="css">CSS</label>
            <br>
            <p>选择的项是：{{checked}}</p>

        </div>
        <div>
            <input type="checkbox" v-model="toggle" :true-value="value1" :false-value = "value2">
            <label>复选框{{toggle}}</label>
        </div>
        <div>
            <input type="text" v-model.lazy ="message">
            <p>{{message}}</p>
        </div>
        <div>
            <input type="number" v-model.number ="numberMessage">
            <p>{{typeof numberMessage}}</p>
        </div>
        <my-cpmponet>

        </my-cpmponet>
    </div>
</template>

<script>
    export default {
        name: 'HelloWorld',
        data() {
            return {
                checked: [],
                toggle: "",
                value1: "a",
                value2: "b",
                message:"",
                numberMessage:null
            }
        },

        props: {
            msg: String
        }
    }
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
    h3 {
        margin: 40px 0 0;
    }

    ul {
        list-style-type: none;
        padding: 0;
    }

    li {
        display: inline-block;
        margin: 0 10px;
    }

    a {
        color: #42b983;
    }
</style>

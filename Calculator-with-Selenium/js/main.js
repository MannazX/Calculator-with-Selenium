const app = Vue.createApp({
    data() {
        return {
            intro : "Calculator made using Vue.js and Selenium Framework",
            result : 0
        }
    },
    methods: {
        assignSum() {
            this.result = parseInt(this.number1) + parseInt(this.number2)
        }
    },
    computed: {
        
    }
});
<template>
    <div>
      <h1>公司營業收入</h1>
      <p>總資料筆數: {{ totalCount }}</p>
      <table>
        <thead>
          <tr>
            <th>公司代號</th>
            <th>公司名稱</th>
            <th>產業別</th>
            <th>當月營業收入</th>
            <th>去年同月增減(%)</th>
            <th>備註</th>
          </tr>
        </thead>
        <tbody>
          <tr v-for="company in companies" :key="company.id">
            <td>{{ company.companyCode }}</td>
            <td>{{ company.companyName }}</td>
            <td>{{ company.industryType }}</td>
            <td align="right">{{ company.monthlyRevenue }}</td>
            <td align="right">{{ roundedComparison[company.id] }}</td>
            <td align="left">{{ company.remark }}</td>
          </tr>
        </tbody>
      </table>
    </div>
  </template>
  
  <script>
  import axios from 'axios';
  
  export default {
    data() {
      return {
        companies: [],
      };
    },
    computed: {
      totalCount() {
        return this.companies.length;
      },
      roundedComparison() {
            return this.companies.reduce((acc, company) => {
                if (typeof company.lastYearComparison === 'number') {
                    acc[company.id] = Math.round(company.lastYearComparison * 100) / 100;
                }
                return acc;
            }, {});
        }
    },
    created() {
      this.fetchRevenues();
    },
    methods: {
      async fetchRevenues() {
        try {
          const response = await axios.get('http://localhost:5078/api/CompanyRevenue/GetAllCompany');
          this.companies = response.data;
        } catch (error) {
          console.error(error);
        }
      },
      getRoundedComparison(value) {
            if (typeof value === 'number') {
                return Math.round(value * 100) / 100; // 四捨五入到小數第二位
            }
            return 0; // 預設值
        }
    },
  };
  </script>
  
  <style scoped>
  table {
    width: 100%;
    border-collapse: collapse;
  }
  th, td {
    border: 1px solid #ddd;
    padding: 8px;
  }
  </style>
  
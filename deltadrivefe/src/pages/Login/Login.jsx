import { useForm } from "react-hook-form";
import { yupResolver } from "@hookform/resolvers/yup";
import * as Yup from "yup";


import React from 'react';
import {LoginForm} from "../../components/User/LoginForm";

const Login = () => {
    return (
        <div>
            {/*<h1>Login</h1>*/}
            <LoginForm></LoginForm>
        </div>
    );
}

export default Login;

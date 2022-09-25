import { Content } from "antd/lib/layout/layout";
import { useState } from "react";
import RegisterComponent from "../components/Register";
import SignIn from "../components/SignIn";

const LoginPage = () => {
  const [register, setRegister] = useState(false);

  const toggleRegister = () => setRegister(!register);

  return (
    <Content className="log-in">
      {register ? (
        <RegisterComponent toggleRegister={toggleRegister} />
      ) : (
        <SignIn toggleRegister={toggleRegister} />
      )}
    </Content>
  );
};

export default LoginPage;

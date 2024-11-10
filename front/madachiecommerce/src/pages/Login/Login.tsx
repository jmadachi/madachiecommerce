import { useDispatch } from "react-redux";
import { login } from "../../services";
import { useNavigate } from "react-router-dom";
import { PrivateRoutes } from "../../routes";
import { createUser } from "../../redux/states/user";


export default function Login() {
  const dispatch = useDispatch();
  const navigate = useNavigate();


  const authentication = async () => {
    try {
      
      const result = await login({name:'jmadachi@hotmail.com', password:'P@$$w0rd'});
      console.log(`result = ${result}`);
      dispatch(createUser(result));
      navigate(`/${PrivateRoutes.ORDER_MANAGEMENT}`, {replace:true});
    }
    catch (error) {
        console.log(error)
    }
  };

  return (
    <div>
      <h1>Login</h1>
      <button onClick={authentication}>Login</button>
    </div>
  )
}

import { useDispatch } from "react-redux";
import { login } from "../../services";
import { createUser } from "../../redux/states/user";

export default function Login() {

  const dispatch = useDispatch();

  const authentication = async () => {
    try {
      const result = await login();
      dispatch(createUser(result));
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

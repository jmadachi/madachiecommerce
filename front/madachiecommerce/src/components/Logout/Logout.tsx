import { useNavigate } from "react-router-dom";
import { resetUser, userKey } from "../../redux/states/user";
import { deleteLocalStorage } from "../../tools"
import { PublicRoutes } from "../../routes";
import { useDispatch } from "react-redux";

export default function Logout() {
    const navigate = useNavigate();

    const dispatch = useDispatch();
    
    const logOut = () => {
        deleteLocalStorage(userKey);
        dispatch(resetUser());
        navigate(PublicRoutes.LOGIN, {replace: true});
    };
    return (
        <button onClick={logOut}>Log Out</button>
    )
}

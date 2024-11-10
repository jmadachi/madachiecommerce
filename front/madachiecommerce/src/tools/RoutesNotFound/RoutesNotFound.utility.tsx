import { Route, Routes } from "react-router-dom";

interface Props {
    children: JSX.Element[] | JSX.Element;
}

export default function RoutesNotFound({children}: Props){
    return( 
        <Routes>
            {children}
            <Route path="*" element={<>PAGE NOT FOUNT</>} />
        </Routes>
    );
}
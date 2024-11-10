export const saveLocalStorage = <T>(key: string, value: T) => {
    localStorage.setItem(key, JSON.stringify({...value}));
};

export const deleteLocalStorage = (key: string) => {
    localStorage.removeItem(key);
};


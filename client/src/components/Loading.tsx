import { Spin } from "antd";

const Loading = () => {
  return (
    <div className="loading">
      <Spin style={{ color: "orange" }} size="large" tip="Loading..." />
    </div>
  );
};

export default Loading;
